using UnityEngine;
using System.Collections;
using Vuforia;

public class FirefighterTracker : MonoBehaviour, ITrackableEventHandler
{

    private TrackableBehaviour mTrackableBehaviour;


    private GameObject fireCar;
    private bool mShowGUIButton = false;
    private Rect mButtonRect = new Rect(50, 50, 120, 60);
    private Waypoints waypoint;
    void Start()
    {
        fireCar = GameObject.Find("fireCar");
        waypoint = fireCar.GetComponent("Waypoints") as Waypoints;

        fireCar.SetActive(false);
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
        {
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }
    }

    public void OnTrackableStateChanged(
                                    TrackableBehaviour.Status previousStatus,
                                    TrackableBehaviour.Status newStatus)
    {
        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED)
        {
            waypoint.isAnimating = true;
            mShowGUIButton = true;
            fireCar.SetActive(true);
        }
        else
        {
            mShowGUIButton = false;
        }
    }

    void OnGUI()
    {
        if (mShowGUIButton)
        {
            // draw the GUI button
            if (GUI.Button(mButtonRect, "Hello"))
            {
                // do something on button click 
            }
        }
    }
}
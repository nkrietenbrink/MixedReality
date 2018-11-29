using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoints : MonoBehaviour {

    public GameObject[] waypoints;
    int current = 0;
    float rotSpeed;
    public float speed;
    public float[] rotations;
    public bool repeat;
    public bool backward;
    private bool isBackward;
    public float WPradius;
    public bool isAnimating;

    void Update()
    {
        if(isAnimating) {
            transform.position = Vector3.MoveTowards(transform.position, waypoints[current].transform.position, Time.deltaTime * speed);
            if (Vector3.Distance(waypoints[current].transform.position, transform.position) < WPradius)
            {
                
                if (!isBackward)
                {
                    if (rotations.Length > 0) transform.Rotate(0, rotations[current], 0);
                    current++;
                    if (current >= waypoints.Length)
                    {
                        if (backward)
                        {
                            transform.Rotate(0, 180, 0);
                            isBackward = true;
                            current-=2;
                        }
                        else if (repeat)
                        {
                            current = 0;
                        }
                        else
                        {
                            isAnimating = false;
                        }
                    } else { 
}
                }
                else
                {
                    if (rotations.Length > 0 && rotations[current] != 0) transform.Rotate(0, rotations[current] + 180, 0);
                    if (current == 0)
                    {
                        if (repeat)
                        {
                            current = 0;
                            transform.Rotate(0, 180, 0);
                            isBackward = false;
                        }
                        else
                        {
                            isAnimating = false;
                        }
                    } else
                    {
                        current--;
                    }
                }
            }
        }
    }
}

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
    public float WPradius;
    public bool isAnimating;
    public GameObject fireCar;
    private void Start()
    {
        fireCar = GameObject.Find("fireCar");
    }
    void Update()
    {
        if(isAnimating) {

            Debug.Log("fireCar.transform.position:  " + fireCar.transform.position);
            Debug.Log("transform.position:  " + transform.position);

            if (Vector3.Distance(fireCar.transform.position, transform.position) < 10){
            } else {
                isAnimating = true;
                transform.position = Vector3.MoveTowards(transform.position, waypoints[current].transform.position, Time.deltaTime * speed);
                if (Vector3.Distance(waypoints[current].transform.position, transform.position) < WPradius)
                {
                    transform.Rotate(0, rotations[current], 0);
                    current++;

                        if  (current >= waypoints.Length)
                    {
                            if(repeat) {
                                current = 0;
                            
                        } else {
                            isAnimating = false;
                        }
                        }
                                
                }

        }


    }
    }
}

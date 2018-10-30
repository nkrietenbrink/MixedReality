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
    public bool setActive;

    void Update()
    {
        if(setActive) {
        if (Vector3.Distance(waypoints[current].transform.position, transform.position) < WPradius)
        {
            current ++;
            if (repeat && current >= waypoints.Length)
            {
                current = 0;
            }
            transform.Rotate(0, rotations[current], 0);
        }
        transform.position = Vector3.MoveTowards(transform.position, waypoints[current].transform.position, Time.deltaTime * speed);
       


    }
    }
}

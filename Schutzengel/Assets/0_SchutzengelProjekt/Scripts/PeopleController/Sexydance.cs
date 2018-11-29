﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sexydance : MonoBehaviour
{

    private Animator animator;

    // Use this for initialization
    void Start()
    {
        this.animator = this.GetComponent<Animator>();
        if (this.animator != null)
        {
            this.animator.SetFloat("Speed_f", 0);
            this.animator.SetBool("Grounded", true);
            this.animator.SetBool("Static_b", false);
            this.animator.SetInteger("Animation_int", 4);
            this.animator.SetInteger("WeaponType_int", 0);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

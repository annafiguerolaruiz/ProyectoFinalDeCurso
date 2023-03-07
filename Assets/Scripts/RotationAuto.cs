using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationAuto : MonoBehaviour
{

    public float xSpeed = 0.0f;
    public float ySpeed = 0.0f;
    public float zSpeed = 0.0f;

    private void Start()
    {
       
    }

    private void Update()
    {
        transform.Rotate(
            xSpeed * Time.deltaTime,
            ySpeed * Time.deltaTime,
            zSpeed * Time.deltaTime
       );
    }
}
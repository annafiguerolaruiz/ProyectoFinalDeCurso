using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    public JumpBall Ball;

    private float offset;

    void Start()
    {
        //We subtract from the position of the camera, the position of the ball.
        offset = transform.position.y - Ball.transform.position.y;
    }

    void Update()
    {
        Vector3 actualPos = transform.position;
        actualPos.y = Ball.transform.position.y + offset;
        transform.position = actualPos;
    }
}

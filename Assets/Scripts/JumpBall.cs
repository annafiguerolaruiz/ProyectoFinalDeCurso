using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBall : MonoBehaviour
{

    public Rigidbody Rb;
    public float BallImpulse = 8f;

    private bool IgnoreNextCollision;

    //When our ball collides with something...
    private void OnCollisionEnter(Collision collision)
    {

   
        //When the ball collides with something, it will take a few seconds before it can collide again.
        if (IgnoreNextCollision)
        {
            return;
        }

        //We specify that when we collide with something, we add a point
        GameManager.GM.AddScore(1);

        Rb.velocity = Vector3.zero;
        Rb.AddForce(Vector3.up*BallImpulse, ForceMode.Impulse);

        IgnoreNextCollision = true;
        //Time it will take to crash again
        Invoke("UpcomingCollision",0.2f);
    }


    //Allow next collision
    private void UpcomingCollision ()
    {
        IgnoreNextCollision = false;
    }
}

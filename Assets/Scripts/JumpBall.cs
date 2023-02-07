using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class JumpBall : MonoBehaviour
{

    public Rigidbody Rb;
    public float BallImpulse = 8f;

    private bool IgnoreNextCollision;
    private Vector3 startPosition;
    public int perfectPass;
    private float superSpeed = 13;
    private bool superSpeedActive;
    private int perfectPassCount = 3;
    private DeatPart script;

    //Save initial position of the ball
    private void Start()
    {
        startPosition = transform.position;
    }

    //When our ball collides with something...
    private void OnCollisionEnter(Collision collision)
    {

   
        //When the ball collides with something, it will take a few seconds before it can collide again.
        if (IgnoreNextCollision)
        {
            return;
        }

        //Verification: If we are in super speed and the platform against which we collide is not the one that contains the tag "meta", we destroy it.

        if (superSpeedActive && !collision.transform.GetComponent<GoalController>())
        {
            Destroy(collision.transform.parent.gameObject,0.2f); //When the ball collides with the platform in super speed and destroys it, the super speed will disappear after 2.0 seconds.
        }
        else
        {
            //Let's check if the platform the player crashed on has the script "DeatPart".
            script = collision.transform.GetComponent<DeatPart>();
            //If the player collides with a platform with the script "DeatPart" the level will restart from 0.
            if (script)
            {
                GameManager.GM.RestartLevel();
            }
        }

        //Let's check if the platform the player crashed on has the script "DeatPart".
        script = collision.transform.GetComponent<DeatPart>();
        //If the player collides with a platform with the script "DeatPart" the level will restart from 0.
        if (script)
        {
            GameManager.GM.RestartLevel();
        }

        //We specify that when we collide with something, we add a point
        //GameManager.GM.AddScore(1);

        Rb.velocity = Vector3.zero;
        Rb.AddForce(Vector3.up*BallImpulse, ForceMode.Impulse);

        IgnoreNextCollision = true;
        //Time it will take to crash again
        Invoke("UpcomingCollision",0.2f);


        //If we collide with something, our perfect pass is again 0 and our super speed disappears
        perfectPass = 0;
        superSpeedActive = false;
    }


    private void Update()
    {
        //Verification
        if (perfectPass>=perfectPassCount && !superSpeedActive)
        {
            superSpeedActive = true;
        }
    }

    //Allow next collision
    private void UpcomingCollision ()
    {
        IgnoreNextCollision = false;
    }

    //Our current position is the same as the beginning
    public void ResetBall()
    {
        transform.position = startPosition;
    }
    public void OnTriggerEnter(Collider other)
    {
        //When the ball makes contact with the collider tagged with the tag "Meta" we change level
        if (other.CompareTag("Meta"))
        {
            GameManager.GM.CurrentLevel++;            

            if (GameManager.GM.CurrentLevel < PlayerPrefs.GetInt("Current_Level"))
            {
                GameManager.GM.CurrentLevel = PlayerPrefs.GetInt("Current_Level");
            }

            SceneManager.LoadScene(GameManager.GM.CurrentLevel);
        }

    }
}

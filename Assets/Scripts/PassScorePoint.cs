using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassScorePoint : MonoBehaviour
{
    //When the ball makes contact with the box collider, a point is added to the game.
    private void OnTriggerEnter(Collider other)
    {
        GameManager.GM.AddScore(1);
    }



}

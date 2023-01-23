using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeatPart : MonoBehaviour
{
    //When we assign this script to some component of the game, it will turn red.
    private  void OnEnable()
    {
        gameObject.GetComponent<Renderer>().material.color = Color.red;
    }

}

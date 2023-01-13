using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelixController : MonoBehaviour
{
    private Vector2 LastTouchPosition;
    private Vector3 StartPosition;

    
    void Start()
    {
        //Initial position of the Helix
        StartPosition = transform.localEulerAngles;
    }

    
    void Update()
    {
        //To identify if we are pressing on the screen with the mouse;
        if (Input.GetMouseButton(0))
        {
            Vector2 currentTapPosition = Input.mousePosition;

            if (LastTouchPosition == Vector2.zero)
            {
                LastTouchPosition = currentTapPosition;
            }

            float distance = LastTouchPosition.x - currentTapPosition.x;
            LastTouchPosition = currentTapPosition;

            //We multiply the distance and depending on it (negative or positive) we will move to the left or to the right
            transform.Rotate(Vector3.up * distance);
        }

        //We detect if we have stopped clicking the mouse on the screen
         if (Input.GetMouseButtonUp(0))
        {
            LastTouchPosition = Vector2.zero;
        }
    }
}

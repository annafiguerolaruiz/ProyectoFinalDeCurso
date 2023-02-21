using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{   
    public float zRotation = 180f;
    private bool active = true;

    private void Start()
    {
        
    }

    private void Update()
    {
        if(active)
        {
            active = false;
            StartCoroutine(zRotationCamera());
        }
    }

    public IEnumerator zRotationCamera()
    {
        transform.Rotate(transform.rotation.x, transform.rotation.y, 0f); //Normal
        yield return new WaitForSeconds(5f);
        transform.Rotate(transform.rotation.x, transform.rotation.y, zRotation); //Invertido
        yield return new WaitForSeconds(5f);
        active = true;
    }
}

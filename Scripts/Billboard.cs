using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    // Update is called once per frame
    void LateUpdate()
    {
        transform.forward = Camera.main.transform.forward; //Have it look in the direction of the camera
    }
}

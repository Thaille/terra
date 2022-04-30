using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotationSkyDome : MonoBehaviour
{

    public Transform copyThisCamera;


    private void Update()
    {
        transform.rotation = copyThisCamera.rotation;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPOV : MonoBehaviour
{
    // No need start void since we are following the POV in the void update

    [SerializeField] GameObject MyPOV;

    // Update is called once per frame
    void LateUpdate() // we change the Update() to LateUpdate()
    {
        transform.position = MyPOV.transform.position + new Vector3(0,0,-10); 
        // vector3 is the position where will be the camera it is important to 
        // edit the z axis to negative number in order to see the game in 2D perspective
    }
}

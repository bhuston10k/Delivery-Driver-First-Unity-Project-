using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    // This script is a component of the Camera in Unity
    
    // Create Serialized GameObject variable, and specifcy the Esteem.
    [SerializeField] GameObject thingToFollow;

    void LateUpdate()
    {
        // Camera's position matches the Esteem's position, with a -10 z offset
        transform.position = thingToFollow.transform.position + new Vector3 (0,0,-10);
    }
}

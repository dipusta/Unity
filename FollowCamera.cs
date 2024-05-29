using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    //This thing's (camera) position should be the same as the car's position
    [SerializeField] GameObject thingtoFollow;
    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = thingtoFollow.transform.position + new Vector3(0,0,-10);   
    }
}

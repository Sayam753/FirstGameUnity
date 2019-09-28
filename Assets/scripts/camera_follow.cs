using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_follow : MonoBehaviour
{
    public Transform sayam;
    public Vector3 offset;
    // Update is called once per frame
    void Update()
    {
        transform.position = sayam.position + offset; 
    }
}

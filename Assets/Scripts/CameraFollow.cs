using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform doodlePos;
    public float smoothSpeed;
    public Vector3 offset;

    void FixedUpdate()
    {
        if (doodlePos.position.y > transform.position.y) 
        {
            Vector3 newPos = new Vector3(transform.position.x, doodlePos.position.y, transform.position.z) + offset;
            transform.position = Vector3.Lerp(transform.position, newPos, smoothSpeed);
        }
    }
}

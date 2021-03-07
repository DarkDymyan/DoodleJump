using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float forceJump;                                         
    public void OnCollisionEnter2D(Collision2D collision)           
    {
        if (collision.relativeVelocity.y < 0f)
        {
            Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                rb.velocity = Vector2.up * forceJump;
            }
        }
    }
}

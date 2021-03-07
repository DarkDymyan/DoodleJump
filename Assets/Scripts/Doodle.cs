using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Rigidbody2D))]
public class Doodle : MonoBehaviour
{
    public float movementSpeed;

    private float _movement;
    private Rigidbody2D _DoodleRigid;
    void Start()
    {
        _DoodleRigid = GetComponent<Rigidbody2D>();
    }


    void FixedUpdate()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            _movement = Input.acceleration.x;
        }
        else 
        {
            _movement = Input.GetAxis("Horizontal");
        }

        if (_movement > 0)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }
        else
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }

        _DoodleRigid.velocity = new Vector2(_movement * movementSpeed, _DoodleRigid.velocity.y);
    }

    public void OnCollisionEnter2D(Collision2D collision)    
    {
        if (collision.collider.name == "LoseZone")           
        {
            SceneManager.LoadScene(0);                      
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rigidbody2d;
    public float jumpVelocity;
    bool onFloor = false;
    private void Awake()
    {
        rigidbody2d = transform.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space) && onFloor == true)
        {
            Jump();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Floor"))
        {
            onFloor = true;
        }
    }
    void Jump()
    {
        rigidbody2d.velocity = Vector2.up * jumpVelocity;
        onFloor = false;
    }
}

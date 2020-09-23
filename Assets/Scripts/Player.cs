/*
 * Created by: Ruel Coy
 *
 * Purpose: Controls the Player Object 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D _rigidbody2d; // Rigidbody2d of the player object.
    public float jumpVelocity;
    bool _onFloor = false;
    private void Awake()
    {
        _rigidbody2d = transform.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space) && _onFloor)
        {
            Jump();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Floor"))
        {
            _onFloor = true;
        }
    }
    void Jump()
    {
        _rigidbody2d.velocity = Vector2.up * jumpVelocity;
        _onFloor = false;
    }
}

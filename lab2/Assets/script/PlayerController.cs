using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float moveInput;
    [SerializeField] private float jump = 5f;
    [SerializeField] private float speed = 5;

    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private CollectColor playerColor;

    

    // Update is called once per frame
    // Player MoveMent input
    void FixedUpdate()
    {
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
    }

    //Player move input by Axist
    private void OnMove(InputValue value)
    {
        moveInput = value.Get<float>();
        //Debug.Log($"Float of moveInput is {moveInput}");
    }


    private void OnJump(InputValue value)
    {
        if (value.isPressed)
        { 
            rb.AddForce(transform.up * jump, ForceMode2D.Impulse);
        }
    }
    
     private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Collectable collectable))
        {
            CollectColor playerColor = collectable.color;

            switch (playerColor)
            {
                case CollectColor.Yellow:
                    spriteRenderer.color = Color.yellow;
                    break;
                case CollectColor.Green:
                    spriteRenderer.color = Color.green;
                    break;
                case CollectColor.Blue:
                    spriteRenderer.color = Color.blue;
                    break;
            }
            Destroy(collectable.gameObject);
        }
    }

}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 5;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }


    void Update()
    {
        float moveInput = Input.GetAxis("Horizontal");
        // Debug.Log ($"Input value: {moveInput}");
        rb.velocity = new Vector2(moveInput + speed, rb.velocity.y);

    }
}
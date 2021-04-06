using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;

    public Rigidbody2D rb;

    Vector2 movement;

    private Inventory inventory;

    private void Awake()
    {
        inventory = new Inventory();
    }

    void Update()
    {
        MovementInput();
    }

    private void FixedUpdate()
    {
        //movement calc
        rb.velocity = movement * moveSpeed;
    }

    void MovementInput()
    {
        float mx = Input.GetAxisRaw("Horizontal");
        float my = Input.GetAxisRaw("Vertical");

        movement = new Vector2(mx, my).normalized;
    }
}

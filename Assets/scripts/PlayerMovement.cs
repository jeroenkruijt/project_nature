// Player Face Screen Code by Brackeyes (https://www.youtube.com/watch?v=LNLVOjbrQj4)
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;

    public Rigidbody2D rb;
    public Camera cam;

    Vector2 movement;
    Vector2 mousePos;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        MovementInput();

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

    }

    private void FixedUpdate()
    {
        //movement calc
        rb.velocity = movement * moveSpeed;
        //Directional Vector from Player to Mouse Position
        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
    }

    void MovementInput()
    {
        float mx = Input.GetAxisRaw("Horizontal");
        float my = Input.GetAxisRaw("Vertical");

        movement = new Vector2(mx, my).normalized;

    }
}

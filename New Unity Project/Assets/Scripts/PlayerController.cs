using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 10f;
    public Rigidbody2D rb;

    private float moveX;
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

   
    void Update()
    {
        moveX = Input.GetAxis("Horizontal") * moveSpeed;
    }

    private void FixedUpdate()
    {
        Vector2 velocity = rb.velocity;
        velocity.x = moveX;
        rb.velocity = velocity;
    }

    void OnBecameInvisible()
    {
        GameManager.vivo = false;
        Destroy(this.gameObject);
    }
}

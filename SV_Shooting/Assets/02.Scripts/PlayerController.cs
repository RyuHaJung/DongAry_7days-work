using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    public float moveSpeed;
    public Vector2 moveInput;

    public Transform topLeft;
    public Transform bottomRight;

    public Animator Player;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Player = GetComponent<Animator>();
    }

    void Update()
    {
        moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        rb.velocity = moveInput * moveSpeed;

        transform.position = new Vector3(Mathf.Clamp(transform.position.x,topLeft.position.x,bottomRight.position.x),
                                                Mathf.Clamp(transform.position.y, bottomRight.position.y,topLeft.position.y),
                                                            transform.position.z);
        Player.SetFloat("Movement",moveInput.y);
    }

}

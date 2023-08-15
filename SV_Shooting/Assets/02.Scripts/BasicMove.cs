using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMove : MonoBehaviour
{
    public float moveSpeed;
    public float rotSpeed;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb.velocity = new Vector2(moveSpeed, 0);
        transform.rotation = Quaternion.Euler(0f,0f,transform.rotation.eulerAngles.z + (Random.Range(rotSpeed / 2f,rotSpeed) * Time.deltaTime));
        // transform.Rotate(0, 0, this.rotSpeed * Time.deltaTime);
    }
}

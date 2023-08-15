using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float moveSpeed;

    void Update()
    {
        transform.position = new Vector3(transform.position.x + (moveSpeed * Time.deltaTime), transform.position.y, transform.position.z);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObject);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}

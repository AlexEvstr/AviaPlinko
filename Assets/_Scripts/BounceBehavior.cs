using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceBehavior : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            var force = collision.gameObject.GetComponent<Rigidbody2D>();
            force.AddForce(Vector2.up, ForceMode2D.Impulse);
        }
    }
}

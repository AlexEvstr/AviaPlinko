using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceBehavior : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            StartCoroutine(ChangeSize());
        }
    }

    private IEnumerator ChangeSize()
    {
        transform.localScale = new Vector3(0.25f, 0.25f, 0.25f);
        yield return new WaitForSeconds(0.1f);
        transform.localScale = new Vector3(0.15f, 0.15f, 0.15f);
    }
}

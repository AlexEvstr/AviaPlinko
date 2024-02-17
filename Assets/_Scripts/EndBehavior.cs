using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndBehavior : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            StartCoroutine(ChangePosition());
        }
    }

    private IEnumerator ChangePosition()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y - 0.1f, transform.position.z);
        yield return new WaitForSeconds(0.1f);
        transform.position = new Vector3(transform.position.x, transform.position.y + 0.1f, transform.position.z);
    }
}

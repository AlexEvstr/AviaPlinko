using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketDetector : MonoBehaviour
{
    [SerializeField] private GameObject _explosion;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("LeftEnemy") || collision.gameObject.CompareTag("RightEnemy"))
        {
            
            GameObject newExplosion = Instantiate(_explosion);
            newExplosion.transform.position = new Vector2(collision.gameObject.transform.position.x, collision.gameObject.transform.position.y);
            Destroy(newExplosion, 1f);
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}

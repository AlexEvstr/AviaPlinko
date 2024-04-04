using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneCollision : MonoBehaviour
{
    [SerializeField] private GameObject _explosion;
    [SerializeField] private GameObject _minus10Gems;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("LeftEnemy"))
        {

            GameObject newExplosion = Instantiate(_explosion);
            newExplosion.transform.position = new Vector2(collision.gameObject.transform.position.x, collision.gameObject.transform.position.y);
            Destroy(newExplosion, 1f);
            Destroy(collision.gameObject);

            GameObject minus10 = Instantiate(_minus10Gems);
            minus10.transform.position = new Vector2(-4.5f, 3);
            Destroy(minus10, 1);
            GameData.score -= 10;
        }
        else if (collision.gameObject.CompareTag("RightEnemy"))
        {
            GameObject newExplosion = Instantiate(_explosion);
            newExplosion.transform.position = new Vector2(collision.gameObject.transform.position.x, collision.gameObject.transform.position.y);
            Destroy(newExplosion, 1f);
            Destroy(collision.gameObject);

            GameObject minus10 = Instantiate(_minus10Gems);
            minus10.transform.position = new Vector2(4.5f, 3);
            Destroy(minus10, 1);
            GameData.score -= 10;
        }
        
    }
}

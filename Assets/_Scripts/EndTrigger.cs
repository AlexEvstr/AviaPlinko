using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        string countOfPoints = collision.gameObject.tag;
        if (countOfPoints == "0")
        {
            Destroy(gameObject);
        }
        else if (countOfPoints == "5")
        {
            Destroy(gameObject);
            GameData.score += 5;
        }
        else if (countOfPoints == "10")
        {
            Destroy(gameObject);
            GameData.score += 10;
        }
        else if (countOfPoints == "25")
        {
            Destroy(gameObject);
            GameData.score += 25;
        }
        else if (countOfPoints == "50")
        {
            Destroy(gameObject);
            GameData.score += 50;
        }
        else if (countOfPoints == "100")
        {
            Destroy(gameObject);
            GameData.score += 100;
        }
    }

    private void Update()
    {
        if (transform.position.y < -7)
        {
            Destroy(gameObject);
        }
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        string countOfPoints = collision.gameObject.tag;
        if (countOfPoints == "0")
        {
            Destroy(gameObject);
            Debug.Log(0);
            return;
        }
        else if (countOfPoints == "5")
        {
            Destroy(gameObject);
            Debug.Log(5);
            GameData.score += 5;
        }
        else if (countOfPoints == "10")
        {
            Destroy(gameObject);
            Debug.Log(10);
            GameData.score += 10;
        }
        else if (countOfPoints == "25")
        {
            Destroy(gameObject);
            Debug.Log(25);
            GameData.score += 25;
        }
        else if (countOfPoints == "50")
        {
            Destroy(gameObject);
            Debug.Log(50);
            GameData.score += 50;
        }
        else if (countOfPoints == "100")
        {
            Destroy(gameObject);
            Debug.Log(100);
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
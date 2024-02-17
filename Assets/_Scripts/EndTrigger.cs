using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D collision)
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
            //score += 5;
        }
        else if (countOfPoints == "10")
        {
            Destroy(gameObject);
            Debug.Log(10);
            //score += 10;
        }
        else if (countOfPoints == "25")
        {
            Destroy(gameObject);
            Debug.Log(25);
            //score += 25;
        }
        else if (countOfPoints == "50")
        {
            Destroy(gameObject);
            Debug.Log(50);
            //score += 50;
        }
        else if (countOfPoints == "100")
        {
            Destroy(gameObject);
            Debug.Log(100);
            //score += 100;
        }

    }
}

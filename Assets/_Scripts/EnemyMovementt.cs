using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementt : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void FixedUpdate()
    {
        transform.Translate(Vector2.left * Time.deltaTime * _speed);
    }
}

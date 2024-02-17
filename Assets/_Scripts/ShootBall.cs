using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBall : MonoBehaviour
{
    [SerializeField] private GameObject _plane;
    [SerializeField] private GameObject _ball;

    public void CreateBall()
    {
        GameObject ball = Instantiate(_ball);
        ball.transform.position = _plane.transform.position;
    }
}

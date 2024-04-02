using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootRocket : MonoBehaviour
{
    [SerializeField] private GameObject _rocketRight;
    [SerializeField] private GameObject _rocketLeft;
    [SerializeField] private GameObject _plane;

    public void ShootRightRocket()
    {
        GameObject newRocket = Instantiate(_rocketRight);
        newRocket.transform.position = new Vector2(_plane.transform.position.x, _plane.transform.position.y);
    }

    public void ShootLeftRocket()
    {
        GameObject newRocket = Instantiate(_rocketLeft);
        newRocket.transform.position = new Vector2(_plane.transform.position.x, _plane.transform.position.y);
    }
}
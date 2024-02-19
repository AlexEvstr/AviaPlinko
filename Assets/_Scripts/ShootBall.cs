using UnityEngine;

public class ShootBall : MonoBehaviour
{
    [SerializeField] private GameObject _plane;
    [SerializeField] private GameObject _ball;

    private bool _canShoot;

    public void CreateBall()
    {
        if (_canShoot)
        {
            GameObject ball = Instantiate(_ball);
            ball.transform.position = _plane.transform.position;
        }
    }

    private void Update()
    {
        GameObject oldBall = GameObject.FindWithTag("Ball");
        if (oldBall != null)
        {
            _plane.GetComponent<SpriteRenderer>().color = Color.red;
            _canShoot = false;
        }

        else
        {
            _plane.GetComponent<SpriteRenderer>().color = new Color(1,1,1);
            _canShoot = true;
        }
    }
}
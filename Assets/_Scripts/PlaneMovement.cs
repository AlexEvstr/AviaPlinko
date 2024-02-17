using UnityEngine;

public class PlaneMovement : MonoBehaviour
{
    [SerializeField] private float _speed = 2.5f;


    private void Update()
    {
        transform.Translate(Vector2.right * _speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Border"))
            ChangeDirection();
    }

    private void ChangeDirection()
    {
        _speed = -_speed;
    }
}
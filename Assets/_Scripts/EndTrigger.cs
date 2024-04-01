using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    [SerializeField] private AudioClip _endClip;
    [SerializeField] private AudioClip _endClipBad;

    private AudioSource _audioSource;

    private void Start()
    {
        _audioSource = GameObject.FindGameObjectWithTag("Manager").GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        string countOfPoints = collision.gameObject.name;
        if (countOfPoints == "0")
        {
            Destroy(gameObject);
            _audioSource.PlayOneShot(_endClipBad);

        }
        else if (countOfPoints == "-10")
        {
            Destroy(gameObject);
            _audioSource.PlayOneShot(_endClipBad);
            GameData.score -= 10;
        }
        else if (countOfPoints == "5")
        {
            _audioSource.PlayOneShot(_endClip);
            Destroy(gameObject);
            GameData.score += 5;
        }
        else if (countOfPoints == "10")
        {
            _audioSource.PlayOneShot(_endClip);
            Destroy(gameObject);
            GameData.score += 10;
        }
        else if (countOfPoints == "25")
        {
            _audioSource.PlayOneShot(_endClip);
            Destroy(gameObject);
            GameData.score += 25;
        }
        else if (countOfPoints == "50")
        {
            _audioSource.PlayOneShot(_endClip);
            Destroy(gameObject);
            GameData.score += 50;
        }
        else if (countOfPoints == "100")
        {
            _audioSource.PlayOneShot(_endClip);
            Destroy(gameObject);
            GameData.score += 100;
        }
        else if (countOfPoints == "1000")
        {
            _audioSource.PlayOneShot(_endClip);
            Destroy(gameObject);
            GameData.score += 1000;
        }
    }

    private void Update()
    {
        if (transform.position.y < -7)
        {
            _audioSource.PlayOneShot(_endClipBad);
            Destroy(gameObject);
        }
    }
}
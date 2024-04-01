using System.Collections;
using UnityEngine;

public class BounceBehavior : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private AudioClip _audioClip;

    [SerializeField] private ColorManager _colorManager;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            StartCoroutine(ChangeSize());
        }
    }

    private IEnumerator ChangeSize()
    {
        
        _audioSource.PlayOneShot(_audioClip);
        transform.localScale = new Vector3(0.35f, 0.35f, 0.35f);

        gameObject.GetComponent<SpriteRenderer>().color = _colorManager.TakeRandomColor();

        yield return new WaitForSeconds(0.1f);

        gameObject.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1);

        transform.localScale = new Vector3(0.25f, 0.25f, 0.25f);
    }
}

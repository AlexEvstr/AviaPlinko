using UnityEngine;
using UnityEngine.SceneManagement;

public class PausePanel : MonoBehaviour
{
    private AudioSource _audioSource;

    [SerializeField] private AudioClip _clickSound;
    [SerializeField] private GameObject _pausePanel;

    private void Start()
    {
        _audioSource = gameObject.GetComponent<AudioSource>();
    }

    public void UnPauseGame()
    {
        _pausePanel.SetActive(false);
        Time.timeScale = 1;
        PlaySound();
    }

    public void ReplayGame()
    {
        SceneManager.LoadScene("GameScene");
        Time.timeScale = 1;
        PlaySound();
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("MenuScene");
        Time.timeScale = 1;
        PlaySound();
    }

    private void PlaySound()
    {
        _audioSource.PlayOneShot(_clickSound);
    }
}

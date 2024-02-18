using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PausePanel : MonoBehaviour
{
    [SerializeField] private GameObject _pausePanel;

    public void UnPauseGame()
    {
        _pausePanel.SetActive(false);
        Time.timeScale = 1;
    }

    public void ReplayGame()
    {
        SceneManager.LoadScene("GameScene");
        Time.timeScale = 1;
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("MenuScene");
        Time.timeScale = 1;
    }
}

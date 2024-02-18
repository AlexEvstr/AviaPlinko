using UnityEngine;

public class PauseButton : MonoBehaviour
{
    [SerializeField] private GameObject _pausePanel;
    [SerializeField] private GameObject _pauseButton;

    public void PauseGame()
    {
        MaKePause();
    }

    private void MaKePause()
    {
        _pausePanel.SetActive(true);
        Time.timeScale = 0;
    }
}
using UnityEngine;

public class SoundsManager : MonoBehaviour
{
    [SerializeField] private GameObject _on;
    [SerializeField] private GameObject _off;

    private void OnEnable()
    {
        LoadStatus();
    }

    private void LoadStatus()
    {
        int status = PlayerPrefs.GetInt("sound", 0);
        if (status == 0)
        {
            SoundOn();
        }
        else
        {
            SoundOff();
        }
    }

    public void SoundOn()
    {
        _off.SetActive(false);
        _on.SetActive(true);
        AudioListener.volume = 1;
    }

    public void SoundOff()
    {
        _on.SetActive(false);
        _off.SetActive(true);
        AudioListener.volume = 0;
    }

    private void OnDisable()
    {
        SaveStatus();
    }

    private void SaveStatus()
    {
        if (_on.activeInHierarchy)
        {
            PlayerPrefs.SetInt("sound", 0);
        }
        else
        {
            PlayerPrefs.SetInt("sound", 1);
        }
    }
}

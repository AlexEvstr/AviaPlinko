using UnityEngine;

public class SoundsManager : MonoBehaviour
{
    [SerializeField] private GameObject _on;
    [SerializeField] private GameObject _off;

    [SerializeField] private AudioClip _clickSound;
    private AudioSource _audioSource;

    private void OnEnable()
    {
        LoadStatus();
    }

    private void Start()
    {
        _audioSource = gameObject.GetComponent<AudioSource>();
    }

    public void ClickButtonSound()
    {
        _audioSource.PlayOneShot(_clickSound);
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
        SaveStatus();
    }

    public void SoundOff()
    {
        _on.SetActive(false);
        _off.SetActive(true);
        AudioListener.volume = 0;
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

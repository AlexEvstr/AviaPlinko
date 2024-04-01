using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuPanel : MonoBehaviour
{
    [SerializeField] private GameObject _shopPanel;
    [SerializeField] private GameObject _shopPlanePanel;
    [SerializeField] private GameObject _shopBallPanel;
    [SerializeField] private TMP_Text _scoreText;

    private void Start()
    {
        GameData.score = PlayerPrefs.GetInt("score", 0);
    }

    public void StartGAme()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void ShopButton()
    {
        _shopPanel.SetActive(true);
    }

    public void OpenPlaneShop()
    {
        _shopPlanePanel.SetActive(true);
    }

    public void OpenBallShop()
    {
        _shopBallPanel.SetActive(true);
    }

    public void BackToMenu()
    {
        _shopPanel.SetActive(false);
    }

    public void BackToShopFromPlanes()
    {
        _shopPlanePanel.SetActive(false);
    }

    public void BackToShopFromBalls()
    {
        _shopBallPanel.SetActive(false);
    }

    private void OnDestroy()
    {
        PlayerPrefs.SetInt("score", GameData.score);
    }

    private void Update()
    {
        _scoreText.text = GameData.score.ToString();
    }
}
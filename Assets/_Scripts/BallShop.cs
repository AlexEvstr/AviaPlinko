using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallShop : MonoBehaviour
{
    [SerializeField] private GameObject _flag;
    [SerializeField] private int _priceSum;

    [SerializeField] private GameObject _price;
    [SerializeField] private GameObject _owned;

    private void Start()
    {
        string ballName = PlayerPrefs.GetString("Ball", "");
        if (gameObject.name == ballName)
        {
            _flag.transform.SetParent(gameObject.transform);
        }
    }

    public void ClickBall()
    {
        Debug.Log(transform.childCount);
        if (!_owned.activeInHierarchy)
        {
            GameData.score -= _priceSum;
            SaveStatus();
        }

        PlayerPrefs.SetString("Ball", gameObject.name);

        _flag.transform.SetParent(gameObject.transform);

        MakeOwned();
    }

    private void SaveStatus()
    {
        if (gameObject.name.Contains("0"))
        {
            PlayerPrefs.SetString("ball_0", "unlocked");
        }
        else if (gameObject.name.Contains("1"))
        {
            PlayerPrefs.SetString("ball_1", "unlocked");
        }
        else if (gameObject.name.Contains("2"))
        {
            PlayerPrefs.SetString("ball_2", "unlocked");
        }
        else if (gameObject.name.Contains("3"))
        {
            PlayerPrefs.SetString("ball_3", "unlocked");
        }
    }

    private void Update()
    {
        CheckBall();
        CheckPrice();
        CheckStatus();
    }

    private void CheckBall()
    {
        if (gameObject.transform.childCount == 4)
        {
            gameObject.GetComponent<Image>().color = Color.green;
        }
        else
        {
            gameObject.GetComponent<Image>().color = new Color(1, 1, 1);
        }
    }

    private void CheckPrice()
    {
        if (_priceSum > GameData.score && !_owned.activeInHierarchy)
        {
            gameObject.GetComponent<Button>().interactable = false;
        }
        else
        {
            gameObject.GetComponent<Button>().interactable = true;
        }
    }

    private void CheckStatus()
    {
        if (gameObject.name.Contains("0"))
        {
            if (PlayerPrefs.GetString("ball_0", "") != "")
            {
                MakeOwned();
            }
        }
        else if (gameObject.name.Contains("1"))
        {
            if (PlayerPrefs.GetString("ball_1", "") != "")
            {
                MakeOwned();
            }
        }
        else if (gameObject.name.Contains("2"))
        {
            if (PlayerPrefs.GetString("ball_2", "") != "")
            {
                MakeOwned();
            }
        }
        else if (gameObject.name.Contains("3"))
        {
            if (PlayerPrefs.GetString("ball_3", "") != "")
            {
                MakeOwned();
            }
        }
    }

    private void MakeOwned()
    {
        _price.SetActive(false);
        _owned.SetActive(true);
    }
}
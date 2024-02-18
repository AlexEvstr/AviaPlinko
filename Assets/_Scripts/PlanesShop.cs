using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlanesShop : MonoBehaviour
{
    [SerializeField] private GameObject _flag;
    [SerializeField] private int _priceSum;

    [SerializeField] private GameObject _price;
    [SerializeField] private GameObject _owned;

    private void Start()
    {
        string planeName = PlayerPrefs.GetString("Plane", "");
        if (gameObject.name == planeName)
        {
            _flag.transform.SetParent(gameObject.transform);
        }
    }

    public void ClickPlane()
    {
        if (!_owned.activeInHierarchy)
        {
            GameData.score -= _priceSum;
            SaveStatus();
        }

        PlayerPrefs.SetString("Plane", gameObject.name);

        _flag.transform.SetParent(gameObject.transform);

        MakeOwned();
    }

    private void SaveStatus()
    {
        if (gameObject.name.Contains("0"))
        {
            PlayerPrefs.SetString("plane_0", "unlocked");
        }
        else if (gameObject.name.Contains("1"))
        {
            PlayerPrefs.SetString("plane_1", "unlocked");
        }
        else if (gameObject.name.Contains("2"))
        {
            PlayerPrefs.SetString("plane_2", "unlocked");
        }
    }

    private void Update()
    {
        CheckPlane();
        CheckPrice();
        CheckStatus();
    }

    private void CheckPlane()
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
            if (PlayerPrefs.GetString("plane_0", "") != "")
            {
                MakeOwned();
            }
        }
        else if (gameObject.name.Contains("1"))
        {
            if (PlayerPrefs.GetString("plane_1", "") != "")
            {
                MakeOwned();
            }
        }
        else if (gameObject.name.Contains("2"))
        {
            if (PlayerPrefs.GetString("plane_2", "") != "")
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
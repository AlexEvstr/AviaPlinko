using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData : MonoBehaviour
{
    public static int score;

    private void OnEnable()
    {
        score = PlayerPrefs.GetInt("score", 0);
    }

    private void OnDestroy()
    {
        PlayerPrefs.SetInt("score", score);
    }
}

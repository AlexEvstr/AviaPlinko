using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    private void Update()
    {
        if (GameData.score > 0)
        {
            gameObject.GetComponent<TMP_Text>().text = GameData.score.ToString();
        }

        else
        {
            GameData.score = 0;
            gameObject.GetComponent<TMP_Text>().text = 0.ToString();
        }
    }
}
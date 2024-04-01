using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    private void Update()
    {
        gameObject.GetComponent<TMP_Text>().text = GameData.score.ToString();
    }
}
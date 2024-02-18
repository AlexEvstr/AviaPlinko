using UnityEngine;
using UnityEngine.UI;

public class GameData : MonoBehaviour
{
    [SerializeField] private GameObject _plane;
    [SerializeField] private Sprite[] _planes;

    public static int score;

    private void OnEnable()
    {
        score = PlayerPrefs.GetInt("score", 0);

        string name = PlayerPrefs.GetString("Plane", "");

        for (int i = 0; i < _planes.Length; i++)
        {
            if (_planes[i].name == name)
            {
                _plane.GetComponent<SpriteRenderer>().sprite = _planes[i];
            }
        }
        
    }

    private void OnDestroy()
    {
        PlayerPrefs.SetInt("score", score);
    }
}

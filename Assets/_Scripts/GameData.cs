using UnityEngine;

public class GameData : MonoBehaviour
{
    [SerializeField] private GameObject _plane;
    [SerializeField] private Sprite[] _planes;

    [SerializeField] private GameObject _ball;
    [SerializeField] private Sprite[] _balls;

    public static int score;

    private void OnEnable()
    {
        score = PlayerPrefs.GetInt("score", 0);
        LoadPlane();
        LoadBall();
    }

    private void LoadPlane()
    {
        string planeName = PlayerPrefs.GetString("Plane", "");

        for (int i = 0; i < _planes.Length; i++)
        {
            if (_planes[i].name == planeName)
            {
                _plane.GetComponent<SpriteRenderer>().sprite = _planes[i];
            }
        }
    }

    private void LoadBall()
    {
        string ballName = PlayerPrefs.GetString("Ball", "");

        for (int i = 0; i < _balls.Length; i++)
        {
            if (_balls[i].name == ballName)
            {
                _ball.GetComponent<SpriteRenderer>().sprite = _balls[i];
            }
        }
    }

    private void OnDestroy()
    {
        PlayerPrefs.SetInt("score", score);
    }
}
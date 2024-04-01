using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorManager : MonoBehaviour
{
    [SerializeField] private Color[] _colors;

    public Color TakeRandomColor()
    {
        int randomIndex = Random.Range(0, _colors.Length);
        return _colors[randomIndex];
    }

}

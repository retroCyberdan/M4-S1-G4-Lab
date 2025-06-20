using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorManager : MonoBehaviour
{
    [SerializeField] private Renderer _renderer;

    public Color SelectedColor { get; private set; }

    public void SetSelectedColor(Color color)
    {
        SelectedColor = color;
        if(_renderer != null) _renderer.material.color = SelectedColor;
    }
}
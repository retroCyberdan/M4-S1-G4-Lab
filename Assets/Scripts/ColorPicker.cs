using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPicker : MonoBehaviour
{
    private Material _material;
    private ColorManager _colorManager;

    void Start()
    {
        _material = GetComponent<MeshRenderer>().material;
        _colorManager = FindAnyObjectByType<ColorManager>();
    }

    void OnMouseDown()
    {
        _colorManager.SetSelectedColor(_material.color);
    }
}
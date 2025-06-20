using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetColor : MonoBehaviour
{
    private Material _material;
    private Color _defaultColor;
    private ColorManager _colorManager;

    void Start()
    {
        _material = GetComponent<MeshRenderer>().material;
        _colorManager = FindAnyObjectByType<ColorManager>();
        _defaultColor = _material.color;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1)) // <- con click destro riporta al colore di default
        {
            _material.SetColor("_BaseColor", _defaultColor);
        }
    }
    void OnMouseDown()
    {
        _material.color = _colorManager.SelectedColor; // <- quando clicco con il mouse, richiama la property in ColorManager
    }
}
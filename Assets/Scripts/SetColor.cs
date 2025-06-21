using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SetColor : MonoBehaviour
{
    private Camera _cam;
    private Material _material;
    private ColorManager _colorManager;
    private Color _defaultColor;

    void Start()
    {
        _cam = Camera.main;
        _material = GetComponent<MeshRenderer>().material;
        _colorManager = FindAnyObjectByType<ColorManager>();
        _defaultColor = _material.color;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            _material.SetColor("_BaseColor", _defaultColor); // <- ripristina il colore di default con il tasto destro

        }

        if (Input.GetMouseButton(0)) // <- con tasto sinistro premuto
        {
            Ray ray = _cam.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                if (hit.transform == transform) // <- controllo se l'oggetto colpito è questo stesso oggetto
                {
                    _material.color = _colorManager.SelectedColor;
                }
            }
        }
    }
}
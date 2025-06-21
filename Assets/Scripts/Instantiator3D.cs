using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiator3D : MonoBehaviour
{
    [SerializeField] GameObject _cubePrefab;
    [SerializeField] int _xAxis = 10;
    [SerializeField] int _yAxis = 10;
    [SerializeField] int _zAxis = 10;
    [SerializeField] float _offsetX = 1.1f;
    [SerializeField] float _offsetY = 1.1f;
    [SerializeField] float _offsetZ = 1.1f;

    void Start()
    {
        CreateCubeGrid();
    }

    private void CreateCubeGrid() // <- creo un metodo che gestisce la creazione di una griglia 3D
    {
        float x = transform.position.x;
        float y = transform.position.y;
        float z = transform.position.z;
        Vector3 startPos = new Vector3(x, y, z); // <- gli passo le coordinate del punto di origine

        for (int i = 0; i < _zAxis; i++)
        {
            for (int j = 0; j < _yAxis; j++)
            {
                for (int k = 0; k < _xAxis; k++)
                {
                    Vector3 position = new Vector3(startPos.x + k * _offsetX, startPos.y + j * _offsetY, startPos.z + i * _offsetZ);
                    Instantiate(_cubePrefab, position, Quaternion.identity, transform);
                }
            }
        }
    }
}
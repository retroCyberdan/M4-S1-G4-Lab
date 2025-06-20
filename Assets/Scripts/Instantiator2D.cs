using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEngine.Rendering.DebugUI.Table;

public class Instantiator2D : MonoBehaviour
{
    [SerializeField] GameObject _quadPrefab;
    [SerializeField] int _columns = 5;
    [SerializeField] int _rows = 5;
    [SerializeField] float _offsetColumns = 1.1f;
    [SerializeField] float _offsetRows = 1.1f;

    void Start()
    {
        CreateGrid();
    }

    private void CreateGrid()
    {
        float x = transform.position.x;
        float y = transform.position.y;
        Vector3 startPos = new Vector3(x, y, 0);

        for (int i = 0; i < _rows; i++)
        {
            for (int j = 0; j < _columns; j++)
            {
                Vector3 position = new Vector3(startPos.x + j * _offsetColumns, startPos.y + i * _offsetRows, 0f);
                Instantiate(_quadPrefab, position, Quaternion.identity, transform);
            }
        }
    }
}
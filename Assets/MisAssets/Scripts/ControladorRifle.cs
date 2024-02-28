using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 
/// </summary>

public class ControladorRifle : MonoBehaviour
{
    #region 1)Definicion de variables
    [SerializeField] private Vector3 desfasePos;
    #endregion

    #region 2)Funciones predeterminadas Unity
    void Awake()
    {
        
    }
    void Start()
    {
        
    }

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Vector3 _posRifle = ray.origin;
        _posRifle.z = 0f;

        transform.position = _posRifle + desfasePos;
        
    }
    #endregion

    #region 3)Metodos originales

    #endregion
}

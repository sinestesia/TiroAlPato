using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 
/// </summary>

public class ControladorRifle : MonoBehaviour
{
    [SerializeField] private Vector3 desfasePos;
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Vector3 _posRifle = ray.origin;
        _posRifle.z = 0f;

        transform.position = _posRifle + desfasePos;

        //Acción al pulsar botón izquierdo
        /*
        if (Input.GetMouseButtonDown(0))
        {
            //TODO: Sonido rifle
        }
        */
    }
}

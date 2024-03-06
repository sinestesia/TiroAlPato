using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///
/// DESCRIPCION:
///
/// </summary>

public class MovimientoZigZag : MonoBehaviour
{

    // -----------------------------------------------------------------
    #region 1) Definicion de Variables
    public float limitePosX;
    public float dirMovimiento;

    public float velocidad;
#endregion
// -----------------------------------------------------------------
#region 2) Funciones Predeterminadas de Unity 
    void Awake (){

        if (dirMovimiento == 0f) dirMovimiento = 1f;
	}

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x >= limitePosX || transform.position.x <= -limitePosX) dirMovimiento *= -1f;

        transform.Translate(Vector3.right * dirMovimiento * velocidad * Time.deltaTime, Space.World);
        
    }
#endregion
// -----------------------------------------------------------------
#region 3) Metodos Originales

#endregion
// -----------------------------------------------------------------

}

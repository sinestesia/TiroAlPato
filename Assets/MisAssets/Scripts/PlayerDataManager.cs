using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///
/// DESCRIPCION:
///
/// </summary>

public class PlayerDataManager : MonoBehaviour
{

    // -----------------------------------------------------------------
    #region 1) Definicion de Variables
    public static PlayerDataManager instancia;

    public DatosPlayer datosPlayer;
#endregion
// -----------------------------------------------------------------
#region 2) Funciones Predeterminadas de Unity 
void Awake (){
        instancia = this;
	}

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
#endregion
// -----------------------------------------------------------------
#region 3) Metodos Originales
    public void AgregarPuntos (int _puntosNuevos)
    {
        datosPlayer.puntuacion += _puntosNuevos;
    }
#endregion
// -----------------------------------------------------------------

}

[Serializable]
public class DatosPlayer
{
    public int puntuacion;
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerDataManager : MonoBehaviour
{
    public static PlayerDataManager instancia;

    public PlayerData datosJugador; // contiene toda la info que se va a guardar/cargar

    void Awake()
    {
        instancia = this;
        datosJugador.puntuacion = 0;
        datosJugador.record = 0;
    }


    public void AgregarPuntos(int _puntos)
    {
        datosJugador.puntuacion += _puntos;
        //HUDManager.instancia.ActualizarPuntuacion();
        Debug.Log(datosJugador.puntuacion);
    }

    public bool RecordSuperado()
    {
        if (datosJugador.puntuacion > datosJugador.record) return true;
        else return false;
    }
  
}


// Se definen los datos que van a ser exportados o importados en un sistema de guardado de partidas
[Serializable]
public class PlayerData
{
    public int puntuacion;
    public int record;
}
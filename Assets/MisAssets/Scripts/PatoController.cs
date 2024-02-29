using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;



public class PatoController : MonoBehaviour
{
    private EstadosPato estadoPato;
    [SerializeField, Range(0,100)] private int puntoPato;

    private void Awake()
    {
        EstablecerEstadoPato(EstadosPato.Vivo);
    }

    private void Update()
    {
        if (estadoPato == EstadosPato.Vivo) { 
            //TODO: Mover Pato
        }
    }

    //Detecta cuando se hace click sobre el pato y lo mata
    private void OnMouseDown()
    {
        //Matar Pato
        EstablecerEstadoPato(EstadosPato.Muerto); 
    }
    private void EstablecerEstadoPato(EstadosPato nuevoEstado) {
        estadoPato = nuevoEstado;
        switch (estadoPato)
        {
            case EstadosPato.Vivo:
                //TODO: Posicionar pato en carril
                //TODO: Configurar movimiento Pato

                break;
            case EstadosPato.Muerto:
                //Incrementar puntos
                PlayerDataManager.instancia.AgregarPuntos(puntoPato);
                //TODO: Sonido Alcanzado
                //TODO:  Animar girando
                Collider2D collider = GetComponent<Collider2D>();
                collider.enabled = false;
                Animator anim = GetComponent<Animator>();
                anim.SetBool("vivo", false);
                //Destruye pato
                Destroy(gameObject, 0.2f);
                break;
        }
    }
}

public enum EstadosPato { 
    Vivo,
    Muerto
}

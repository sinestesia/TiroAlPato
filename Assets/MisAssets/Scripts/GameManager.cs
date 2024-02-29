using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static GameManager instancia;



    void Awake()
    {

        if (instancia == null)
        {
            // Se crea la figura del GameManager en mi juego
            instancia = this;
            DontDestroyOnLoad(gameObject);

            // una vez creado, se activa su primer hijo en la jerarquía para
            // que se crean el resto de gestores
            transform.GetChild(0).gameObject.SetActive(true);
        }
        else Destroy(gameObject);
    }

    // Start is called before the first frame update

    /*void Start()
    {
        EstablecerEstadoActualSegunEscena();
    }*/

}




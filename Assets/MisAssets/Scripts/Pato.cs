using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///
/// DESCRIPCION:
///
/// </summary>

public class Pato : MonoBehaviour
{

    // -----------------------------------------------------------------
    #region 1) Definicion de Variables
    Animator anim;

    public float limiteH;
    public bool desaparecido;

#endregion
// -----------------------------------------------------------------
#region 2) Funciones Predeterminadas de Unity 
    void Awake (){
        anim = GetComponent<Animator> ();

        int _anchura = Screen.width;
        int _altura = Screen.height;

        float _relacionAspecto = (float)_anchura / (float)_altura;
        float _anchuraCamara = Camera.main.orthographicSize * 2f * _relacionAspecto;


        limiteH = -_anchuraCamara * 0.5f + 1f;
        transform.position = new Vector3(limiteH, transform.position.y, 0f);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x >= Mathf.Abs(limiteH) && !desaparecido)
        {
            desaparecido = true;
            anim.SetTrigger("desaparece");
        }
        else
        {
            transform.Translate(Vector3.right * Time.deltaTime, Space.World);
        }
    }

    private void OnMouseDown()
    {
        Debug.Log("Click sobre pato");
        anim.SetTrigger("disparado");

        transform.GetChild(1).gameObject.SetActive(true);

        PlayerDataManager.instancia.AgregarPuntos(10);
    }

    private void OnMouseEnter()
    {
        ControladorRifle.instancia.mostrarAgujero = false;
    }

    private void OnMouseExit()
    {
        ControladorRifle.instancia.mostrarAgujero = true;
    }
    #endregion
    // -----------------------------------------------------------------
    #region 3) Metodos Originales
    public void Teletransporte()
    {
        transform.position = new Vector3(limiteH, transform.position.y, 0f);
        anim.Play("Pato_aparece", 0, 0f);
        desaparecido = false;
    }
    #endregion
    // -----------------------------------------------------------------

}

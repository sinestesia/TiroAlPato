using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///
/// DESCRIPCION:
///
/// </summary>

public class Palo : MonoBehaviour
{

    // -----------------------------------------------------------------
    #region 1) Definicion de Variables

    public int vidas;
    public bool estaArreglado;
    public Sprite[] arte;

    SpriteRenderer spriteRenderer;

#endregion
// -----------------------------------------------------------------
#region 2) Funciones Predeterminadas de Unity 
void Awake (){

        vidas = 2;
        spriteRenderer = GetComponent<SpriteRenderer>();

    }

    // Start is called before the first frame update
    void Start()
    {
        ActualizarArteSegunVida();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            estaArreglado = true;
            vidas = 2;
            ActualizarArteSegunVida();
        }
    }

    private void OnMouseDown()
    {

        estaArreglado = false;

        if (vidas > 0)
        {
            vidas--;
            ActualizarArteSegunVida();
        }
    }

    #endregion
    // -----------------------------------------------------------------
    #region 3) Metodos Originales
    void ActualizarArteSegunVida()
    {
        if (!estaArreglado)  spriteRenderer.sprite = arte[vidas - 1];
        else spriteRenderer.sprite = arte[2];
    }
    #endregion
    // -----------------------------------------------------------------

}

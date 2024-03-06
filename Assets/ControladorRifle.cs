using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///
/// DESCRIPCION:
///
/// </summary>

public class ControladorRifle : MonoBehaviour
{

    // -----------------------------------------------------------------
    #region 1) Definicion de Variables
    public static ControladorRifle instancia;

    public Vector3 desfasePos;

    public float limiteIzquierda;
    public float limiteDerecha;

    public float limiteArriba;
    public float limiteAbajo;

    public bool mostrarAgujero;
    public Transform agujeroOriginal;
    #endregion
    // -----------------------------------------------------------------
    #region 2) Funciones Predeterminadas de Unity 
void Awake (){
        instancia = this;
        mostrarAgujero = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(ray.origin, ray.direction * 10f, Color.yellow);

        Vector3 _posSinLimites = ray.origin;
        _posSinLimites.z = 0f;

        if (Input.GetMouseButtonDown(0) && mostrarAgujero)
        {
            Transform _clonAgujero = Instantiate(agujeroOriginal, _posSinLimites, Quaternion.identity);
            Destroy(_clonAgujero.gameObject, 1f);
        }

        #region
        int _anchura = Screen.width;
        int _altura = Screen.height;

        Debug.Log("Res de pantalla. Anchura = " + _anchura);
        Debug.Log("Res de pantalla. Altura = " + _altura);

        float _relacionAspecto = (float)_anchura / (float)_altura;

        Debug.Log("Res. de pantalla. Relacion de aspecto: " + _relacionAspecto);

        float _anchuraConLimites = Camera.main.orthographicSize * 2f * _relacionAspecto;
        float _alturaConLimites = Camera.main.orthographicSize * 2f;

        Debug.Log("La camara capta en Vertical " + _alturaConLimites);
        Debug.Log("La camara capta en Horizontal " + _anchuraConLimites);

        #endregion

        _posSinLimites.x = Mathf.Clamp(_posSinLimites.x, -_anchuraConLimites * .5f + limiteIzquierda, _anchuraConLimites * .5f + limiteDerecha);
        _posSinLimites.y = Mathf.Clamp(_posSinLimites.y, -_alturaConLimites * .5f + limiteAbajo, _alturaConLimites * .5f + limiteArriba);

        transform.position = _posSinLimites + desfasePos;
    }
    #endregion
    // -----------------------------------------------------------------
    #region 3) Metodos Originales

    #endregion
    // -----------------------------------------------------------------

}

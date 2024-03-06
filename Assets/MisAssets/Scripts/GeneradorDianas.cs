using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///
/// DESCRIPCION:
///
/// </summary>

public class GeneradorDianas : MonoBehaviour
{

    // -----------------------------------------------------------------
    #region 1) Definicion de Variables
    public static GeneradorDianas instancia;

    BoxCollider2D boxColl;

    Coroutine generarDianas;

    public int dianasActuales;
    public int dianasMax;

    public Transform dianaOriginal;
    #endregion
// -----------------------------------------------------------------
#region 2) Funciones Predeterminadas de Unity 
void Awake (){
        instancia = this;
        boxColl = GetComponent<BoxCollider2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        Empezar_GenerarDianas();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
#endregion
// -----------------------------------------------------------------
#region 3) Metodos Originales
    void Empezar_GenerarDianas()
    {
        if (generarDianas == null) generarDianas = StartCoroutine(GenerarDianas());
    }

    void Terminar_GenerarDianas()
    {
        if (generarDianas != null)
        {
            StopCoroutine(generarDianas);
            generarDianas = null;
        }
    }

    IEnumerator GenerarDianas()
    {
        // Mientras que la corrutina este en ejecucion...
        while (true)
        {
            if (dianasActuales < dianasMax)
            {
                // Agregamos una diana nueva...
                Transform _dianaClonada = Instantiate(dianaOriginal, Vector3.right * -5f, Quaternion.identity);
                _dianaClonada.SetParent(transform);

                dianasActuales++;

                yield return null;
            }
            else
            {
                Debug.Log("Estan todas las dianas posibles en escena");
                yield return null;
            }
            
            yield return new WaitForSeconds(0.5f);
        }
    }

    public void DianaDerribada()
    {
        dianasActuales--;
    }

    Vector2 RandomPosDentroTrigger()
    {

        Vector2 _sizeTrigger = boxColl.size;
        _sizeTrigger /= 2f;

        //_sizeTrigger.

        return _sizeTrigger;
    }
#endregion
// -----------------------------------------------------------------

}

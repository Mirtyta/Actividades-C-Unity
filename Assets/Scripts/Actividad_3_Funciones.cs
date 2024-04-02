using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class Actividad_3_Funciones : MonoBehaviour
{
    public int a;
    public int b;
    public bool c;

    public TMP_Text resultadoSumaVariables;
    public TMP_Text resultadoSumaValores;
    public TMP_Text resultadoConcatenado;

    // Start is called before the first frame update
    void Start()
    {
    
        Debug.Log("Resultado de la Suma: "+Sumar(a,b,c)); // con variables
        Debug.Log("Resultado de la Suma: "+Sumar(58,12,c)); // con valores        
        resultadoConcatenado.SetText(ConcatenarTexto("Bien Hecho!! ", ", has realizado las sumas correctamente!!")); 
    }

    // Update is called once per frame
    void Update()
    {
        resultadoSumaVariables.SetText("Resultado suma Variables: " + +Sumar(a,b,c)); 
        resultadoSumaValores.SetText("Resultado suma Valores: " + +Sumar(58,12,c)); 
    }

    int Sumar(int numero1, int numero2, bool activar) // void no nos da ningún resultado, por lo tanto es un metodo, en una funcion va int, en el caso de devolver resultado entero
    {
        if(activar)
        {
            int resultado = numero1+numero2;// funcion que realiza sumar
            return resultado;// retorna resultado de la suma
        }
        else
        {
            return 0;
        }

       
    }

    string ConcatenarTexto(string texto1, string texto2)
    {
        string concatenado = texto1+texto2;
        return concatenado;
    }
}

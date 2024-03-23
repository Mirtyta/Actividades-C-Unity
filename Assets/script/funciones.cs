using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Funciones : MonoBehaviour
{
    public int a; //Declaramos una variable de nuemro entero a
    public int b; //Declaramos una variable de numero entero b
    public bool c; //Declaramos una variable del tipo bool llamado c

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(TextoSuma("hola ", ",como estas?")); // Muestra en consola el mensaje
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Resultado de la suma = " + Sumar(a, b, c));// Muestra en consola un mensaje + Un llamado a la Funcion Sumar(a,b,c), donde a y b son valores a sumar y c es un booleano que me dice si devuelve un 0 o el resultado.

    }

    int Sumar(int numero1, int numero2, bool activar) //Las funciones, a diferencia de los metodos, deben devolver un valor. Por eso en vez de usar el void, devuelve un numero entero. Toma los parametros de la funcion.
    {
        if (activar) //Si "activar" es verdadero, hace lo que esta entre las {}
        {
            int resultado = numero1 + numero2; // Hace la suma de los parametros
            return resultado;  //devuelve el resultado
        }
        else //Sino (Si "activar" es falso ), hace lo que esta entre las {}
        {
            return 0; //devuelve el valor 0
        }
    }

    string TextoSuma(string texto1,string texto2) // Se pueden utilizar otros tipos de datos para crear funciones
    {
        string resultado = texto1 + texto2; //Hacemos la suma de los dos textos
        return resultado; //devolvemos el resultado como string
    }
}

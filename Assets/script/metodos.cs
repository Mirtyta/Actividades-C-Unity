using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Metodos : MonoBehaviour
{

    public int monedas;  //Declaracion de la variable "monedas"

    // Start is called before the first frame update
    void Start() //Cuando inicia el programa es lo primero que compila, lo hace uan sola vez.
    {
        

    }

    // Update is called once per frame
    void Update() //Ejecuta el codigo 1 vez por frame, es decir siempre lo va a estar ejecutando.
    {
        ApretarBarra();// Ejecutamos el metodo ApretarBarra()

    }

    void AgarrarMoneda() //Los metodos son fragmentos de codigo que cumplen algun proposito. En este metodo inventado llamado "AgarrarMoneda", suma 1 a la variable "monedas".
    {
        monedas = monedas + 1;// A monedas le suma 1
        Debug.Log(monedas); // muestra el resutlado en consola
    }

    void ApretarBarra() //Creamos este metodo para tener ordenado el código, este metodo se encarga de testear si apretamos la barra de espacio.
    {
        if (Input.GetKeyDown("space")) //Si, se cumple lo que está entre parentesis, entonces activa el metodo AgarrarMoneda() . La condición es que se presione la tecla barra de espacio.
        {
            AgarrarMoneda();//llama al metodo "AgarrarMoneda". Es una buena practica tener el codigo dividido en fragmentos para resolver problemas mas facilmente.
        }
    }
}
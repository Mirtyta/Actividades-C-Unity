using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; // Namespace que necesitamos para trabajar con text mesh pro

public class Variables : MonoBehaviour
{
    // Tipos de datos:
    public int vida = 1000; // tipo de dato = entero
    public string nombre = "Itachi Uchiha"; // caracter o cadena de caracteres
    public float puntaje = 10.5f; // decimal
    public bool ilumacion = true; // booleano o logico
    public string chakra = "Fuego"; 
    public string tChakra = "yin - yang";
    public int edad = 21;
    public string rango = "S+";
    public string signo = "Geminis";

    public GameObject Player;
    
    public TMP_Text textoPuntaje; //Declaro una variable del tipo texto llamado textoPuntaje
    public TMP_Text textoNombre;
    public TMP_Text textoChakra;
    public TMP_Text textoEdad;
    public TMP_Text textoVida;
    public TMP_Text textoTChakra;
    public TMP_Text textoSigno;
    public TMP_Text textoRango;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Puntaje: " + puntaje);
        Debug.Log("Nombre: " + nombre);
        Debug.Log("Iluminacion: " + ilumacion);
        Debug.Log("Vidas: " + vida);
        Debug.Log("Tipo de Chakra: " + tChakra);
        Debug.Log("Edad: " + edad);
        Debug.Log("Naturaleza del Chakra: " + chakra);
        Debug.Log("signo: " + signo);
        Debug.Log("Rango: " + rango);

        Debug.Log("X: " + Player.transform.position.x);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("X: " + Player.transform.position.x + " Y: " + Player.transform.position.y + " Z: " + Player.transform.position.z);
		textoPuntaje.SetText("Puntaje: " + puntaje); //
        textoNombre.SetText("Nombre: " + nombre);
        textoVida.SetText("Vidas: " + vida);
        textoTChakra.SetText("Tipo de Chakra: " + tChakra);
        textoChakra.SetText("Naturaleza del Chakra: " + chakra);
        textoEdad.SetText("Edad: " + edad);
        textoSigno.SetText("Signo: " + signo);
        textoRango.SetText("Rango: " + rango); 
    }
}


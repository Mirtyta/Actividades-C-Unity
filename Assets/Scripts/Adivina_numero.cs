using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 
public class Adivina_numero : MonoBehaviour
{
  // primero defino las variables que debemos utilizar
public int numero;//Esta variable contendrá el valor que ponemos nosotros
private int nroadivinar;// esta es la variable que contentrá el valor que debemos adivinar
public TMP_Text resultado;// esta variable envía según corresponda el mensaje por pantalla
public TMP_Text juego;// esta variable muestra por pantalla las indicaciones del juego
  void Start()
    { // asignamos un valor int random a variable ran
      int ran = Random.Range(1,11);
      // asignamos ese valor random a la variable del numero a adivinar
      nroadivinar = ran;    
      // implemento un IF que evalúa si ambos valores son iguales, tanto el que puse como el numero a adivinar
      if(numero==nroadivinar) 
      {//enviar el mensaje por pantalla
        resultado.SetText("Adivinaste!!, tu numero es: "+numero+" es Igual a: "+nroadivinar+" Bien!!");
      }// sino se cumple la condición.
      else
      {// envia mensaje por pantalla
        resultado.SetText("No!, tu numero es: "+numero+" y no es Igual a: "+nroadivinar+" Prueba de nuevo!!");
      }// texto con las instrucciones del juego
      juego.SetText("El juego consiste en adivinar el número que está entre 1 y 10, para eso, debes cambiar el valor de la variable NUMERO en el objeto VARIABLE, y hacer play, en pantalla saldá si has adivinado o no, si no acertarte, debes parar, cambiar el numero y volver a correr. SUERTE!!");
    }  
}
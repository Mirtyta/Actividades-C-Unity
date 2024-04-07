using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ProbarInput : MonoBehaviour
{
    private int input;
    public TMP_Text dialogo;
    public GameObject popup;

    public int nroSecreto;

    private List<string> respuestasCorrectas = new List<string>();
    private List<string> respuestasIncorrectas = new List<string>();

    void Start()
    {
        // Inicializar respuestas correctas
        respuestasCorrectas.Add("¡Adivinaste! Mi número era {0}. ¡Eres un genio!");
        respuestasCorrectas.Add("¡Correcto! Mi número era {0}. ¡Lo has logrado!");
        // Añadir más respuestas correctas si deseas

        // Inicializar respuestas incorrectas
        respuestasIncorrectas.Add("No, mi número no es {0}. ¡Inténtalo de nuevo!");
        respuestasIncorrectas.Add("¡Incorrecto! El número que buscas no es {0}. ¡Sigue intentándolo!");
        // Añadir más respuestas incorrectas si deseas

        // Generar un número secreto aleatorio al inicio del juego
        nroSecreto = Random.Range(1, 11);

        MostrarDialogoInicio();
    }

    void MostrarDialogoInicio()
    {
        dialogo.SetText("Intenta adivinar un número del 1 al 10.");
    }

    public void CambiarTextInt(string textoInput)
    {
        int.TryParse(textoInput, out input);
        Comparar();
    }

    void Comparar()
    {
        string respuesta;

        if (input == nroSecreto)
        {
            respuesta = string.Format(respuestasCorrectas[Random.Range(0, respuestasCorrectas.Count)], nroSecreto);
            Invoke("MostrarPopup", 2f);
        }
        else
        {
            respuesta = string.Format(respuestasIncorrectas[Random.Range(0, respuestasIncorrectas.Count)], input);
        }

        dialogo.SetText(respuesta);
    }
  

    public void MostrarPopup()
    {
        popup.SetActive(true);
    }

    public void OcultarPopup()
    {
        popup.SetActive(false);
    }

    public void BotonJugar(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void BotonSalir()
    {
        Application.Quit();
    }
}

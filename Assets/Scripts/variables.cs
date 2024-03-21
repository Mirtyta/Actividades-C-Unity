using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class variables : MonoBehaviour
{
    public int vidas = 100;
    public string nombre = "Raon";
    public float points = 11.5f;
    public bool iluminacion = true;
    public GameObject Player;
    public TMP_Text textoPuntaje;

            string textoEstadisticas = "Nombre: Silvannas\n" +
                                    "Raza:No-muerta \n" +
                                    "Altura: 1.6\n" +
                                    "Vida: Desconocida\n"+
                                    "Ubicacion: Entrañas";

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Puntaje: " + points);
        Debug.Log("Nombre: " + nombre);
        Debug.Log("Vidas: " + vidas);
        Debug.Log("Iluminacion: " + iluminacion);


    }

    // Update is called once per frame
    void Update()
    {
                //Debug.Log("X: " + Player.transform.position.x + " Y: " + Player.transform.position.y + " Z: " + Player.transform.position.z);
                textoPuntaje.text = textoEstadisticas;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 
public class ActividadVariables : MonoBehaviour
{
    public GameObject Player;
    string nombre="Mirtyta";
    public int artg= 300,
    aspeed = 4;
    public float apow = 30.5f;
    public string crit = "true";
    public TMP_Text nombrePlayer;
    public TMP_Text atackRating;
    public TMP_Text atackPower; 
    public TMP_Text atackspeed;
    public TMP_Text critical;
    void Start()
    {
        Debug.Log("Nombre: " + nombre);
        Debug.Log("AtackRating: " + artg);
        Debug.Log("AtackPower: " + apow);
        Debug.Log("AtackSpeed: " + aspeed);
        Debug.Log("Critical: " + crit);
    }
    void Update()
    {
        nombrePlayer.SetText(nombre);
        atackRating.SetText(" " + artg); 
        atackPower.SetText(" " +apow); 
        atackspeed.SetText(" " +aspeed); 
        critical.SetText(" " +crit);  
    }
}
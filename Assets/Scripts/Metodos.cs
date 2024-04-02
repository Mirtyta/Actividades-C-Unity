using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class Metodos : MonoBehaviour
{
    public int monedas;
    public TMP_Text cantMonedas;

    // Start is called before the first frame update
    void Start()
    {
  
    }

    
    // Update is called once per frame
    void Update()
    {
    
    ApretarBarra();


    }
    void AgarrarMoneda()
    {
        monedas++;
          Debug.Log("Cantidad de Monedas agarradas: "+monedas);
           cantMonedas.SetText("Cantidad de Monedas: " + monedas); 
    }

    void ApretarBarra()
    {
    if(Input.GetKeyDown("space"))
            {
            AgarrarMoneda();      
            }
    }
}

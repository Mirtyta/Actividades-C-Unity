using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{
  
   //   public void ButtonStart()
   // {
   // 	 SceneManager.LoadScene(1);
   // }
   // 
   // public void ButtonExit()
   // {
   // Application.Quit();
   // }

   public void BotonJugar(string sceneName){ // cargar escena por nombre asignado al buttom
   
      SceneManager.LoadScene(sceneName);
   }

   public void BotonSalir(){
   Application.Quit();
    }

}



using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOverB : MonoBehaviour
{
    public void Jugar()
    {
        SceneManager.LoadScene("nivelUno");
    }

    public void Salir()
    {
        Debug.Log("Salir...");
        Application.Quit();


    }
}

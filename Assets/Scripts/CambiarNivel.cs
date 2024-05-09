using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarNivel : MonoBehaviour
{
    public void CambiarEscena(string nombre)
    {
        SceneManager.LoadScene(nombre);
    }
    public void salir()
    {

        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();

    }
}

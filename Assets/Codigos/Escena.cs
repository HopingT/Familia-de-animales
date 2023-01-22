using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

 

public class Escena : MonoBehaviour
{
    [SerializeField] private GameObject panelsalir;

    
    public void Nexlevel(string level)
        {
        Time.timeScale = 1f;
            SceneManager.LoadScene(level, LoadSceneMode.Single);
        }
    
public void Salir()
    {
        panelsalir.SetActive(true);
    }


    public void CerrarPanel()
    {
        panelsalir.SetActive(false);
    }
    public void CerrarJuego()
    {
        Application.Quit();
        Debug.Log("aplicaccion cerrando");
    }

}

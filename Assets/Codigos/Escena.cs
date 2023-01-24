using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

 

public class Escena : MonoBehaviour
{
    AudioSource AudioFondo;
    [SerializeField] private GameObject panelsalir;
    public void Start()
    {
        AudioFondo = GetComponent<AudioSource>();
    }

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

    private void Awake()
    {
        GameObject[] obj = GameObject.FindGameObjectsWithTag("Music");
        if (obj.Length > 1)
        {
            Destroy(this.gameObject);
        }
        else
        {
            DontDestroyOnLoad(this.gameObject);
        }

    }
}

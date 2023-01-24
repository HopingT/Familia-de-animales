using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinScript3 : MonoBehaviour
{
    private int pointsToWin;
    private int currentPoints;
    public GameObject texto;
    public GameObject BotonContinuar;
    public GameObject textoTrivia, piezas, sombras;

    void Start()
    {
        texto.SetActive(false);
        BotonContinuar.SetActive(false);
    }

    void Update()
    {
        if (currentPoints >= 5)
        {
            //Win

            textoTrivia.SetActive(false);
            piezas.SetActive(false);
            sombras.SetActive(false);
            Time.timeScale = 0f;
            texto.SetActive(true);
            BotonContinuar.SetActive(true);
        }
    }

    public void AddPoints()
    {
        currentPoints++;
    }
}
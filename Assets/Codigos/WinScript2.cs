using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinScript2 : MonoBehaviour
{
    private int pointsToWin;
    private int currentPoints;
    public GameObject texto;
    public GameObject BotonContinuar;

    void Start()
    {
        texto.SetActive(false);
        BotonContinuar.SetActive(false);
    }

    void Update()
    {
        if (currentPoints >= 15)
        {
            //Win
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

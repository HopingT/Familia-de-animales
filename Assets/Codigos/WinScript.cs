using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinScript : MonoBehaviour
{
    private int pointsToWin;
    private int currentPoints;
    public GameObject texto;

    void Start()
    {
        texto.SetActive(false); 
    }

    void Update()
    {
        if (currentPoints >= 5)
        {
            //Win
           texto.SetActive(true);
        }
    }

    public void AddPoints()
    {
        currentPoints++;
    }
}
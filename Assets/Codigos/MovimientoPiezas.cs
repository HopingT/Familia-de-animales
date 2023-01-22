using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPiezas : MonoBehaviour
{

    
    public GameObject FormaCorrecta;
    public GameObject Piezas;
    private bool moving;

    private float posicionX;
    private float posicionY;
    private Vector3 reiniciarPosicion;
    private bool Acabo;
    void Start()
    {
        reiniciarPosicion = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Acabo == false)
        {
            if (moving)
            {
                var mousePosition = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
                transform.position = mousePosition;
                Debug.Log("moviendose");
                
            }
        }
    }

    public void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
           
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            posicionX = mousePos.x - this.transform.localPosition.x;
            posicionY = mousePos.y - this.transform.localPosition.y;


            moving = true;
        }
    }

    private void OnMouseUp()
    {
        moving = false;
       

        float Distance = Vector3.Distance(Piezas.transform.position, FormaCorrecta.transform.position);
        if (Distance < 1f)
        {
            Piezas.transform.position = FormaCorrecta.transform.position;
            Debug.Log("insertado correctamente");
            GameObject.Find("PointHandler").GetComponent<WinScript>().AddPoints();
        }
        else
        {
            FormaCorrecta.transform.position = FormaCorrecta.transform.position ;
            Piezas.transform.position = reiniciarPosicion;
            Debug.Log("reiniciando");

            
        }


    }
}

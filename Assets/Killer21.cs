using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killer21 : MonoBehaviour
{
    public float speed;
    public bool toRight;

    public GameObject baseIzq;
    public GameObject baseDer;

    //public GameObject prefab1;
    //public GameObject prefab2;

    int yOffset;

    void Start()
    {
        toRight = true;
        yOffset = 1;
    }


    void Update()
    {
        if (toRight == false)
        {
            transform.position += new Vector3(speed, 0, 0); //Se mueve en x si "toRight" es true
        }

        else
        {
            transform.position -= new Vector3(speed, 0, 0); //Se mueve en x si "toRight" es false
        }

        if (transform.position.x > baseDer.transform.position.x - 1) //Si esta a 1 metro de la position de la base se convierte el "toRight" se pone false y se ejecuta el primer else  
        {

            toRight = true;
            //GameObject clon;
            //clon = Instantiate(prefab1);
            //clon.transform.position = baseDer.transform.position + new Vector3(0, yOffset, 0);
            //yOffset++;
        }

        if (transform.position.x < baseIzq.transform.position.x + 1) //Si esta a 1 metro se convierte el "toRight" se pone true y convierte el primer if verdadero y lo hace devuelta
        {
            toRight = false;
            //GameObject clon;
            //clon = Instantiate(prefab2);
            //clon.transform.position = baseIzq.transform.position + new Vector3(0, yOffset, 0);
            //yOffset++;
        }

    }

}

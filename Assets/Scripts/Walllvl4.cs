using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walllvl4 : MonoBehaviour
{
    public float speed;
    public bool up;

    //public GameObject baseIzq;
    //public GameObject baseDer;

    // Start is called before the first frame update
    void Start()
    {
        up = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (up == true)
        {
            transform.Translate(0, speed, 0); //Se mueve en y si "up" es true
        }

        else
        {
            transform.Translate (0, -speed, 0); //Se mueve en -y si "up" es false
        }

        if (transform.position.y >= 9) 
        {
            up = false;
        }

        if (transform.position.y <= 7)
        {
            up = true;
        }
    }
}

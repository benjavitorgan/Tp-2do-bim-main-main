using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movingbase : MonoBehaviour
{
    public float speed;
    public bool on;

    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(Example());

        on = true;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (on == true)
        {
            speed = 0.02f;
            transform.Translate(0, 0, -speed); //Se mueve en -z si "up" es true
        }

        else
        {
            speed = 0.01f;
            transform.Translate(0, 0, speed); //Se mueve en z si "up" es false
        }

        if (transform.position.z <= 13.2f)
        {
            on = false;
            //yield return new WaitForSeconds(2);

        }

        if (transform.position.z >= 14.3f)
        {
            on = true;
            //yield return new WaitForSeconds(3);
        }
    }

    }

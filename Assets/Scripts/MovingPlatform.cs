using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float speed;
    public bool toRight;

    // Start is called before the first frame update
    void Start()
    {
        toRight = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (toRight == true)
        {
            transform.Translate(speed, 0, 0); //Se mueve en -z si "up" es true
        }

        else
        {
            transform.Translate(-speed, 0, 0); //Se mueve en z si "up" es false
        }

        if (transform.position.x <= -6)
        {
            toRight = true;
        } 

        if (transform.position.x >= 6)
        {
            toRight = false;
        }
    }
}

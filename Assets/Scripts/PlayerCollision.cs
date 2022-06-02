﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{
    public int counter;
    public Text vidas;
    public Text GO;
    public Text nivel;
    float spawnx, spawny, spawnz;

    // Start is called before the first frame update
    void Start()
    {
        counter = 3;
        GO.text = "";
        //nivel.text = "";
        spawnx = 3.07f;
        spawny = 0.5f;
        spawnz = 7f;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < 0.1f)
        {
            transform.position = new Vector3(spawnx, spawny, spawnz);
            counter--;
        }
    }

    void OnCollisionEnter(Collision col)
    {
        vidas.text = "Vidas: " + counter.ToString();

        if (counter > 0)
        {
            /*
            if (col.gameObject.name == "InicialBase" || col.gameObject.name == "Plane lvl1")
            {
                nivel.text = "Nivel: 1";
            } else if (col.gameObject.name == "Base lvl 2" || col.gameObject.name == "Plane lvl 2")
            {
                nivel.text = "Nivel: 2";
            } else if (col.gameObject.name == "Base lvl 3" || col.gameObject.name == "Plane lvl 3")
            {
                nivel.text = "Nivel: 3";
            }*/

            if (col.gameObject.name == "Checkpoint")
            {
                spawnx = 3.03f;
                spawny = 0.59f;
                spawnz = 21.35f;
            }

            if (col.gameObject.tag == "Killer")
            {
                transform.position = new Vector3(spawnx, spawny, spawnz);
                counter--;
            }

        } else
        {
            Destroy(gameObject);
            GO.text = "¡Game Over!";
        }
    }
}

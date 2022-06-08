using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    int Timecounter;
    float timeToChange;
    public Text txtCountdown;
    public int counter;
    public Text vidas;
    public Text GO;
    public Text Ganaste;
    public Text nivel;
    float spawnx, spawny, spawnz;
    public GameObject InicialBase;
    public GameObject checkpoint;
    public Transform plataforma1;
    public Transform plataforma2;
    public Transform plataforma3;
    public GameObject camara;

    /*
    public GameObject platform1;
    public GameObject platform2;
    public GameObject platform3;
    */

    // Start is called before the first frame update
    void Start()
    {
        Timecounter = 100;
        counter = 3;
        GO.text = "";
        //nivel.text = "";
        spawnx = InicialBase.transform.position.x;
        spawny = 0.5f;
        spawnz = InicialBase.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeToChange < Time.time)
        {          
            if (Timecounter > 0)
            {
                Timecounter--;
                txtCountdown.text = "Tiempo: " + Timecounter.ToString();
                timeToChange++;
            } else {
                counter = 0;
                Timecounter = 0;
            }
        }

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
                spawnx = checkpoint.transform.position.x;
                spawny = checkpoint.transform.position.y + 0.2f;
                spawnz = checkpoint.transform.position.z; 
            }

            if (col.gameObject.name == "Final")
            {
                Ganaste.text = "¡GANASTE!";
                camara.SetActive(true);
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
            camara.SetActive(true);
        }
    }

    public void Reset()
    {
        SceneManager.LoadScene("SampleScene");
    }

    /*
    void OnTriggerStay(Collision col)
    {

        if (col.gameObject.name == "Platform")
        {
            transform.parent = col.transform;

        }
    }

    void OnTriggerExit (Collision col)
    {
        if (col.gameObject.name == "Platform")
        {
            transform.parent = null;

        }
    }
    */
}

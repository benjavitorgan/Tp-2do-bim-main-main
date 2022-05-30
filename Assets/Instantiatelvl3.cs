using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiatelvl3 : MonoBehaviour
{
    public Transform spawner;
    public GameObject cube;
    GameObject clone;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ExampleCoroutine());
    }

    void Update ()
    {

    }

    IEnumerator ExampleCoroutine ()
    {
        while (true)
        {
            clone = Instantiate(cube, spawner.transform.position, spawner.transform.rotation);
            Destroy(clone, 1/*0.5f*/);
            yield return new WaitForSeconds(2);
            
        }
    }
}

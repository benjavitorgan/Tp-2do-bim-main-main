using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiatelvl3 : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Clon();
    }

    public void Clon ()
    {
        GameObject clon;
        clon = Instantiate(gameObject);
        Destroy(clon, 1);
    }
}

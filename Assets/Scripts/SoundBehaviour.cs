using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundBehaviour : MonoBehaviour
{
    AudioSource source;
    //AudioClip salto, perdiste, ganaste, muerte;
    GameObject player;
    bool isPlaying;
    bool gano;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
        //isPlaying = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            source.Play();
        }
    }
}

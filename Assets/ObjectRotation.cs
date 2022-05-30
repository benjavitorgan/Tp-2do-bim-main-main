using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotation : MonoBehaviour
{
    public float RotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        RotationSpeed = 3;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, RotationSpeed, 0);
    }
}

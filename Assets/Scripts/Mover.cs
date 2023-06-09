using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public float MaxSpeed = 10f;
    void Update()
    {
        transform.position += transform.forward * MaxSpeed * Time.deltaTime;
    }
}

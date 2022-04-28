using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walls : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "ball")
        {
           Rigidbody rb= collision.gameObject.GetComponent<Rigidbody>();
            rb.AddForce(new Vector3(Random.Range(200, 1000), Random.Range(200, 1000), Random.Range(200, 1000)));
        }
    }
}

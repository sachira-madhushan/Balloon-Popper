using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    private int clicks=0;
    private Rigidbody rb;
    ScoreAndMenu scoreMenu=new ScoreAndMenu();
    void Start()
    {
        
        rb = GetComponent<Rigidbody>();
        rb.AddForce(new Vector3(Random.Range(200, 1000), Random.Range(200, 1000), Random.Range(200, 1000)));
        
    }

    
    void Update()
    {
        if (clicks == 3)
        {
            Destroy(this.gameObject);
            scoreMenu.UpdateScore();
        }
    }
    private void OnMouseDown()
    {
        this.gameObject.transform.localScale += new Vector3(0.5f, 0.5f,0.5f);
        clicks++;
    }
}

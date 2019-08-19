using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Behaviour : MonoBehaviour
{
    private Rigidbody rb;
    public float thrust;
    
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();


        rb.AddForce(transform.forward * thrust, ForceMode.Acceleration);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

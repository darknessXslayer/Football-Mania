using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Behaviour : MonoBehaviour
{
    private Rigidbody rb;
    public float thrust;
    private List<float> ballAngles = new List<float>() { 0, 90, 180, 270 };
    
    
    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody>();
        transform.rotation = Quaternion.Euler(0, ballAngles[Random.Range(0,4)], 0);
        rb.AddForce(transform.forward * thrust, ForceMode.Acceleration);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

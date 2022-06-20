using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerakanPlayer : MonoBehaviour
{
    public float kecepatan = 5f;
    Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Bergerak();
    }

    void Bergerak()
    {
        float gerak =  Input.GetAxis("Horizontal");
        rb.velocity = Vector3.right * gerak * kecepatan;
        
    }

   
}

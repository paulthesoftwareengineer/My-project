using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody rb; 
    [SerializeField] float mainThrust = 100f;
    [SerializeField] float mainRotation = 100f;



    // Start is called before the first frame update

    void Start()
    {
        rb=GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        ProcessThrust();
        ProcessRotation();
    }

    void ProcessThrust()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("Thrust");
            rb.AddRelativeForce(Vector3.up * mainThrust *Time.deltaTime);
        }

    }

    void ProcessRotation()
    {
            if (Input.GetKey(KeyCode.A))
        {
    
            ApplyRotation(mainRotation);
        }

        else if (Input.GetKey(KeyCode.D))
        {
            ApplyRotation(-mainRotation);
        }
    }

     void ApplyRotation(float rotationThisFrame)
    {
        transform.Rotate(Vector3.forward * mainRotation * Time.deltaTime);
    }
}

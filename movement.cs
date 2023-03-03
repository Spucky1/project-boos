using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{   [SerializeField] float mainThrust = 100f;
    [SerializeField] float rotationThrust = 1f;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
         
     
     
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
       rb.AddRelativeForce(Vector3.up*Time.deltaTime*mainThrust);
        Debug.Log("wORKING");
      }
    }
        void ProcessRotation()
        {
            if (Input.GetKey(KeyCode.A))
            {
               Applyrotation(rotationThrust);
            }
            else if (Input.GetKey(KeyCode.D))
            {
             
             Applyrotation(-rotationThrust);
            } 
             }
            
            
            
            
            
            
            
            
            
            
            void Applyrotation(float rotationThisframe)
            {
                rb.freezeRotation = true;
                transform.Rotate(Vector3.forward*Time.deltaTime*rotationThisframe);
                rb.freezeRotation = false;
            }
        
  } 


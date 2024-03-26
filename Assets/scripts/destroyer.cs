using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collision is with the sphere

            // Destroy the box
            Destroy(gameObject);
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

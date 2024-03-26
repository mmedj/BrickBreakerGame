using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphere : MonoBehaviour
{
    public float forceMagnitude = 10f; // Magnitude of the force to be applied
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Vector3 forceDirection = collision.contacts[0].normal;

        // Apply the force to the sphere
        GetComponent<Rigidbody>().AddForce(forceDirection * forceMagnitude, ForceMode.Impulse);
    }
}

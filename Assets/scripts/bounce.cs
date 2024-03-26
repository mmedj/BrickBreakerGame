using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bounce : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(1, 500, 1);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

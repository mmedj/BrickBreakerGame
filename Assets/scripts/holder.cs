using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class holder : MonoBehaviour
{
    public float speed = 0.02f;
    float input ;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -3.838239)
        {
            transform.position = new Vector3(-3.838239f, transform.position.y, transform.position.z);
        }
        if (transform.position.x > 5.511461)
        {
            transform.position = new Vector3(5.511461f, transform.position.y, transform.position.z);
        }
        input = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward * speed * input);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopVibrating : MonoBehaviour {

    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = input.GetAxis("Horizontal") * moveSpeed;
        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.right * moveSpeed); 
        }
        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody2D>().AddForce(-Vector2.right * moveSpeed);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatingPlatforms : MonoBehaviour
{
    public GameObject platform1;
    public GameObject platform2;
    public float speed;
    void Start()
    {
        
    }


    void Update()
    {
        Rotate();
    }

    private void Rotate()
    {
        transform.Rotate(0, 0, speed);
        platform1.transform.Rotate(0, 0, -speed);
        platform2.transform.Rotate(0, 0, -speed);
    }
}

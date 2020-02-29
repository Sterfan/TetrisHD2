using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropSpeed : MonoBehaviour
{

    private Rigidbody2D rb2D;

    public float maxVelocity;
    public float minVelocity;

    private void Start()
    {
        rb2D = gameObject.GetComponent<Rigidbody2D>();
        Velocity();
    }

    void Velocity()
    {
        rb2D.gravityScale = Random.Range(minVelocity / 10, maxVelocity / 10);
        //Debug.Log(rb2D.gravityScale);
    }

    //float Gravity()
    //{
    //    return Random.Range(minVelocity / 10, maxVelocity / 10);
    //}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathByTime : MonoBehaviour
{
    public float DestroyAfterXsec;
    private float DTimer = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DTimer += 1f * Time.deltaTime;

        if (DTimer > DestroyAfterXsec)
        {


            Destroy(gameObject);

        }
    }
}

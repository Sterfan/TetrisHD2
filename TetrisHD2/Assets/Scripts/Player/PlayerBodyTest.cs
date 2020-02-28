using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBodyTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("Platform"))
            this.transform.parent = col.transform;
    }
    void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("Platform"))
            this.transform.parent = null;
    }
}

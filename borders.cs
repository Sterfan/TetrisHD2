using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class borders : MonoBehaviour
{
    private vector2 screenBounds;
    private float objectWidth;
    private float objectHeight;

    //use this for initialization 

    void start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.Z));
        objectWidth = transform.GetComponent<SpriteRenderer>().bounds.size.x / 2;
        objectHeight = transfrm.GetComponent<SpriteRenderer>().bounds.size.y / 2;
    }
    // update is called once per frame 

    void LateUpdate()
    {
        Vector3 viewPos = transform.position;
        viewPos.x = Mathf.Clamp(viewPos.x, screenBounds.x, screenBounds.x * -1);
        viewPos.y = Mathf.clamp(viewPos.y, screenBounds.y, screenBounds.y * -1);
        transform.position = viewPos;


    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatforms : MonoBehaviour
{

    bool moveRight = true;
    bool moveUp = true;
    float dirEction;

    public bool moveHorizontal;
    public bool moveVertical;
    public float moveSpeed;
    public float maxValue;
    public float minValue;

    // Update is called once per frame
    void Update()
    {
        if (moveVertical == true)
        {
            if (transform.position.y > maxValue)
                moveUp = false;
            if (transform.position.y < minValue)
                moveUp = true;

            if (moveUp)
                transform.position = new Vector2(transform.position.x, transform.position.y + moveSpeed * Time.deltaTime);
            else
                transform.position = new Vector2(transform.position.x, transform.position.y - moveSpeed * Time.deltaTime);
        }
        else if (moveHorizontal == true)
        {
            if (transform.position.x > maxValue)
                moveRight = false;
            if (transform.position.x < minValue)
                moveRight = true;

            if (moveRight)
                transform.position = new Vector2(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y);
            else
                transform.position = new Vector2(transform.position.x - moveSpeed * Time.deltaTime, transform.position.y);
        }
       
    }
}

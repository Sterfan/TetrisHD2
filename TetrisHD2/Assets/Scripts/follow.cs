using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{
    public GameObject playerObject;
    public bool lockYAxis = true;
    //public Vector3 cameraVector;

    void Start()
    {

    }

    //void Update()
    //{
    //    Vector3 cameraVector = new Vector3 (playerObject.transform.position.x, FollowPit(), -10);
    //    transform.position = cameraVector;
    //}

    void Update()
    {
        if (lockYAxis == true)
        {
            if (playerObject.transform.position.y <= -3.8f)
            {
                Vector3 cameraVector = new Vector3(playerObject.transform.position.x, playerObject.transform.position.y, -10);
                transform.position = cameraVector;
            }
            else
            {
                Vector3 cameraVector = new Vector3(playerObject.transform.position.x, 0, -10);
                transform.position = cameraVector;
            }
        }
        else if(lockYAxis == false)
        {
            if (playerObject.transform.position.y >= 0f)
            {
                Vector3 cameraVector = new Vector3(playerObject.transform.position.x, playerObject.transform.position.y, -10);
                transform.position = cameraVector;
            }
            else
            {
                Vector3 cameraVector = new Vector3(playerObject.transform.position.x, 0, -10);
                transform.position = cameraVector;
            }
        }
    }
}

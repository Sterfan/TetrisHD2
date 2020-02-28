using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{
    public GameObject playerObject;
    public Vector3 cameraVector;

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
        if (playerObject.transform.position.y <= -4f)
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

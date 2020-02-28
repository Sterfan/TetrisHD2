using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{
    [SerializeField] GameObject playerObject;
     public Vector3 cameraVector;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 cameraVector = new Vector3 (playerObject.transform.position.x, 0, -10);
        transform.position = cameraVector;
    }
}

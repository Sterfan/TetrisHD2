using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGoBye : MonoBehaviour
{

    public GameObject VertPlat;

    private void OnTriggerEnter2D(Collider2D other)
    {

        VertPlat.SetActive(false);
        
    }
}

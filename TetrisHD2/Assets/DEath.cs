using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DEath : MonoBehaviour
{

    public GameObject Melon;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(Melon);
        AudioManager.PlayMusic("pl_death");
        AudioManager.PlayMusic("gm_lose");
    }
}

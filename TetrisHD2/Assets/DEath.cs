using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DEath : MonoBehaviour
{
    int deathTimer = 2;
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
        deathTimer -= 1;
        if(deathTimer <= 0)
        {
            Debug.Log("Load DeathMenu");
            SceneManager.LoadScene("DeathMenu");
        }
    }
}

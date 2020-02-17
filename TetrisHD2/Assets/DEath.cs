using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DEath : MonoBehaviour
{
    float timer;
    const float waitingTime = 3.0f;
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
        Debug.Log("Load DeathMenu");
        SceneManager.LoadScene("DeathMenu");
        //timer += Time.deltaTime;
        //if(timer >= waitingTime)
        //{
        //    Debug.Log("Load DeathMenu");
        //    SceneManager.LoadScene("DeathMenu");
        //}
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DEath : MonoBehaviour
{
    public GameObject Melon;
    public GameObject Death;
    public GameObject Canvas;
    void Start()
    {

}
    private void Update()
    {
 
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            DeathTimer.StartTimer();
            AudioManager.PlayMusic("pl_death");
            AudioManager.StopMusic("music");
            AudioManager.PlayMusic("gm_lose");
            Melon.SetActive(false);
        }
        else if (other.tag == "Destroy")
        {
            AudioManager.PlayMusic("pl_death");
            AudioManager.StopMusic("music");
            AudioManager.PlayMusic("gm_lose");
            Canvas.SetActive(true);
            Melon.SetActive(false);
        }
        else if (other.tag == "Goal")
        {
            AudioManager.StopMusic("music");
            //AudioManager.PlayMusic("");
            SceneManager.LoadScene("WinMenu");
        }
        else if (other.tag == "Platform")
        {
            return;
        }
    }
}

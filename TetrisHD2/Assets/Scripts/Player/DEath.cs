using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DEath : MonoBehaviour
{
    public GameObject Melon;
    public GameObject Death;
    public GameObject Canvas;

    public GameObject Goal1;
    public GameObject Goal2;
    public GameObject Goal3;

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
            if (Goal1)
            {
                //AudioManager.StopMusic("music");
                //AudioManager.PlayMusic("");
                SceneManager.LoadScene("Zone2");
            }
            else if (Goal2)
            {
                //AudioManager.StopMusic("music");
                //AudioManager.PlayMusic("");
                SceneManager.LoadScene("Zone3");
            }
            else if (Goal3)
            {
                AudioManager.StopMusic("music");
                //AudioManager.PlayMusic("");
                SceneManager.LoadScene("WinMenu");
            }

        }
        else if (other.tag == "Platform")
        {
            return;
        }
    }
}

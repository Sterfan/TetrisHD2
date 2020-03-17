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
    public GameObject Goal4;
    public GameObject Goal5;

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
            //AudioManager.StopMusic("");
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
                AudioManager.StopMusic("Level1");
                AudioManager.PlayMusic("Level2");
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            else if (Goal2)
            {
                AudioManager.StopMusic("Level2");
                AudioManager.PlayMusic("Level3");
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            else if (Goal3)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            else if (Goal4)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            else if (Goal5)
            {
                AudioManager.StopMusic("Level3");
                AudioManager.PlayMusic("gm_win");
                AudioManager.PlayMusic("menu_music");
                SceneManager.LoadScene("WinMenu");
            }

        }
        else if (other.tag == "Platform")
        {
            return;
        }
    }
}

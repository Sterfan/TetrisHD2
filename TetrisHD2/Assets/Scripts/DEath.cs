using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DEath : MonoBehaviour
{
    public GameObject Melon;
    public GameObject Death;
    void Start()
    {

}
    private void Update()
    {
 
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (this.gameObject.tag == "Enemy")
        {
            DeathTimer.StartTimer();
            AudioManager.PlayMusic("pl_death");
            AudioManager.StopMusic("music");
            AudioManager.PlayMusic("gm_lose");
            Melon.SetActive(false);
        }
        else
        {
            AudioManager.StopMusic("music");
            //AudioManager.PlayMusic("gm_lose");
            Debug.Log("Load WinMenu");
            SceneManager.LoadScene("WinMenu");
        }
    }
}

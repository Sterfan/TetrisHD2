using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DEath : MonoBehaviour
{
    public float deathTimer;
    public GameObject Melon;

    private bool startTimer;

    // Start is called before the first frame update
    void Start()
    {
        startTimer = false;       
}
    private void Update()
    {
        if (startTimer == true)
        {
            deathTimer += 1f * Time.deltaTime;

        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Melon.SetActive(false);
        AudioManager.PlayMusic("pl_death");
        AudioManager.PlayMusic("gm_lose");
        startTimer = true;
        if(deathTimer < 5f)
        {
            Debug.Log("Load DeathMenu");
            SceneManager.LoadScene("DeathMenu");
        }
    }
}

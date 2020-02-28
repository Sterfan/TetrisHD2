using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathTimer : MonoBehaviour
{
    private float deathTimer = 0;
    private float deathTimerGoal = 3;
    private static bool startTimer;
    // Start is called before the first frame update
    void Start()
    {
        startTimer = false;
    }

     public static void StartTimer()
    {
        startTimer = true;
    }


    void Update()
    {
        if (startTimer == true)
        {
            deathTimer += 1f * Time.deltaTime;
        }

    
        if (deathTimer > deathTimerGoal)
        {
            Debug.Log("Load DeathMenu");
            SceneManager.LoadScene("DeathMenu");
        }
    }
}

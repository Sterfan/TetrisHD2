using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingBlockSchedule : MonoBehaviour
{
    public float Timer = 0;
    public float TimerGoal;
    public bool Loopable = false;

    public GameObject Block;
    public Transform SpawnPoint;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        Timer += 1f * Time.deltaTime;

        if (Timer > TimerGoal)
        {
            Instantiate(Block, SpawnPoint.position, SpawnPoint.rotation);
            Timer = 0f;
            if (Loopable == false)
            {
                Destroy(gameObject);
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{

    public Transform[] spawnPoints;
    public GameObject[] monsters;
    int randomSpawnPoint, randomMonster;
    public static bool spawnAllowed;
    bool[] shouldSpawn;

    int amountSpawned;
    public int maxAmount = 10;

    void Start()
    {
        shouldSpawn = new bool[10] { true, true, true, true, true, true, true, true, true, true };
        spawnAllowed = true;
        InvokeRepeating("SpawnAMonster", 5f, 7f);
    }

    void SpawnAMonster()
    {
        if (spawnAllowed)
        {
            amountSpawned = Random.Range(0, maxAmount);
            for (int i = 0; i < amountSpawned; i++)
            {
                SpawnChoice();
            }
            ResetArray();
        }
    }

    void ResetArray()
    {
        for (int i = 0; i < shouldSpawn.Length; i++)
        {
            shouldSpawn[i] = true;
        }
    }

    void SpawnChoice()
    {
        randomSpawnPoint = Random.Range(0, spawnPoints.Length);

        if (shouldSpawn[randomSpawnPoint] == true)
        {
            randomMonster = Random.Range(0, monsters.Length);
            Instantiate(monsters[randomMonster], spawnPoints[randomSpawnPoint].position,
                Quaternion.identity);
            shouldSpawn[randomSpawnPoint] = false;
        }
        else
        {
            SpawnChoice();
        }
    }
}

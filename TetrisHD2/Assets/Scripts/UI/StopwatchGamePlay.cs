using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StopwatchGamePlay : MonoBehaviour
{
    float timer = 0f;
    public Text visualisedTime;
    string timeDisplay;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        // timeDisplay = stopWatch.ToString("F1");

        //float timer += Time.deltaTime;

        string minutes = Mathf.Floor(timer / 60).ToString("00");
        string seconds = Mathf.Floor(timer % 60).ToString("00");


        visualisedTime.text = minutes + " : " + seconds;

    }
}

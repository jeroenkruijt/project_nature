using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerController : MonoBehaviour
{
    public float timeValue = 300;
    public Text timeText;
    [SerializeField]
    public bool timerIsRunning = false;
   
    // Start is called before the first frame update
    void Start()
    {
        timerIsRunning = true;
    }
    
    // Update is called once per frame
    void Update()
    {
        if (timerIsRunning)
        {
            if (timeValue > 0)
            {
                timeValue -= Time.deltaTime;
            }
            else
            {
                timeValue = 0;
                timerIsRunning = false;
                SceneManager.LoadScene("Game Over");
            }
        }
        DisplayTime(timeValue);
    }
    void DisplayTime (float timeToDisplay)
    {
        if(timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}

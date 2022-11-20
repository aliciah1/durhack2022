using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WorldScript : MonoBehaviour
{
    
    public float timeStarted;
    public float timeElapsed;
    public float energyPoints;
    public float timeSpeed = 6;

    
    public Button startBtn;
    public Button quitBtn;
    public GameObject statsUI;
    public GameObject menuUI;

    public TextMeshProUGUI timerText;

    double inGameHours = 0.0f;
    double inGameMinutes = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        timeStarted = Time.time;
        startBtn.onClick.AddListener(StartGame);
        quitBtn.onClick.AddListener(EndGame);
    }

    
    void StartGame(){
        timeStarted = Time.time;
        menuUI.SetActive(false);
        statsUI.SetActive(true);
    }

    void EndGame(){
        menuUI.SetActive(true);
        statsUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        timeElapsed = Time.time - timeStarted;

        inGameHours = Math.Floor((timeElapsed * timeSpeed / 60) + 9f);
        inGameMinutes = Math.Floor(timeElapsed * timeSpeed) % 60;

        timerText.text = (inGameHours + ":" + inGameMinutes + " AM");
    }
}

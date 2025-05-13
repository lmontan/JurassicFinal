using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class GameManager : MonoBehaviour
{
    [Header("Timer Components")]
    [SerializeField]
    private float gameTime;
    [SerializeField] TextMeshProUGUI timeTextBox;

    public bool timerOff;

    [SerializeField]
    private ObjectManager objectManager;

    [SerializeField]
    private GameObject GameOverText;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        if (timerOff == false)
        {
            UpdateGameTimer();
        }
        if (gameTime <= 0)
        {
            gameTime = 0f;
            timerOff = true;
            timeTextBox.text = gameTime.ToString();
        }

        if (timerOff == true)
        {
            if(objectManager.artifacts.Count != 0)
            {
                GameOverText.SetActive(true);
            }
        }
    }



    private void UpdateGameTimer()
    {
       gameTime -= Time.deltaTime;

        var minutes = Mathf.FloorToInt(gameTime / 60);
        var seconds = Mathf.FloorToInt(gameTime - minutes * 60);


        string gameTimerClockDisplay = string.Format("{0:0}, {1:00}", minutes, seconds);

        timeTextBox.text = gameTimerClockDisplay;   
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class DinoTimer : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI timerText;

    [SerializeField]
    private TextMeshProUGUI timerLabel;

    private float timer = 180f;

    public bool timerIsOn;

    void Update()
    {
        if (timerIsOn)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                timer = 180;
                timerIsOn = false;
                //SceneManager.LoadScene("GameOver");
            }
        }
        updateTimeDisplay(timer);
    }

    /*private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            timerIsOn = true;
            timerLabel.gameObject.SetActive(true);
            timerText.gameObject.SetActive(true);
        }
    }*/
    private void updateTimeDisplay(float time)
    {

        float minutes = Mathf.FloorToInt(time / 60);
        float seconds = Mathf.FloorToInt(time % 60);
        string currentTime = string.Format("{00:00}{1:00}", minutes, seconds);
        timerText.text = currentTime[0].ToString() + currentTime[1].ToString() + ":" + currentTime[2].ToString() + currentTime[3].ToString();
    }

}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ProBuilder;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    [SerializeField] Text timerText;
    [SerializeField] float maxTimer;
    [SerializeField] GameObject gameOver;
    [SerializeField] GameObject levelMusic;
    float currentTime;
    void Start()
    {
        currentTime = maxTimer;
    }
    void Update()
    {
        Timer();
    }
    public void Timer()
    {
        currentTime -= Time.deltaTime;
        timerText.text = Mathf.Round(currentTime).ToString();
        if (currentTime <= 0)
        {
            gameOver.SetActive(true);
            levelMusic.SetActive(false);
        }
    }
}

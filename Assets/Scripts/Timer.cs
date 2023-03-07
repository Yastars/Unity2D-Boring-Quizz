using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] float timeToCompleteQuestion = 30f;
    [SerializeField] float timeToShowCorrectAnswer = 10f;
    float timerValue;
    float timerRatio;
    public bool isAnsweringQuestion = false;

    void Update() {
        UpdateTimer();
    }

    void UpdateTimer()
    {
        Image timerImage = GetComponentInChildren<Image>();
        timerValue -= Time.deltaTime;
        
        if(isAnsweringQuestion && timerValue <= 0)
        {
            isAnsweringQuestion = false;
            timerValue = timeToShowCorrectAnswer;
            timerRatio = 1/timerValue;
            timerImage.fillAmount = 1.00f;

        }
        else if(timerValue <= 0)
        {
            isAnsweringQuestion = true;
            timerValue = timeToCompleteQuestion;
            timerRatio = 1/timerValue;
            timerImage.fillAmount = 1.00f;
        }

        
        timerImage.fillAmount = timerImage.fillAmount - timerRatio * Time.deltaTime;

        Debug.Log(timerValue);
    }

    void StartTimer()
    {
        
    }
}

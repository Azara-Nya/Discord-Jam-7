using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public bool TimerUp;
    [SerializeField] private float MaxTime;
    [SerializeField] private TextMeshProUGUI ScoreText;
    private float CurrentTime;

    void Update()
    {
        if(CurrentTime >= MaxTime)
        {
            TimerUp=true;
            Debug.Log("Minus 1 Heart");
        }
        else
        {
            CurrentTime += Time.fixedDeltaTime/7;
        }
        ScoreText.text = $"{Math.Round(CurrentTime)}";
    }
}

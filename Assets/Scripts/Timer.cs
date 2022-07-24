using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public bool TimerUp;
    public int health=3;
    [SerializeField] private float MaxTime;
    [SerializeField] private TextMeshProUGUI ScoreText;
    [SerializeField] private GameObject[] hearts;
    private float CurrentTime;

    void Update()
    {
        if(CurrentTime >= MaxTime)
        {
            if(health!=0 && TimerUp==false)
            {
                health -=1;
            }
            TimerUp=true;
        }
        else
        {
            CurrentTime += Time.fixedDeltaTime/7;
        }
        ScoreText.text = $"{Math.Round(CurrentTime)}";

        if(health==2)
        {
            hearts[2].SetActive(false);
        }
        if(health ==1)
        {
            hearts[1].SetActive(false);
        }
        if(health<=0)
        {
            hearts[0].SetActive(false);
            Debug.Log("GameOver");
            Debug.Log("Display Score yada yada");
        }


    if(TimerUp && health !=0)
    {
        //Load Next Scene;
    }
    }

}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Timer : MonoBehaviour
{
    public bool TimerUp;
    public int health=3;
    [SerializeField] private float MaxTime;
    [SerializeField] private float TransTime=1f;
    [SerializeField] private TextMeshProUGUI ScoreText;
    [SerializeField] private GameObject[] hearts;
    private bool HastLoad;
    private float CurrentTime;


void Awake()
{
    DontDestroyOnLoad(this.gameObject);
}
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
        if(!HastLoad)
        {
        StartCoroutine(LoadNextGame());
        HastLoad=true;
        }
    }
    }
IEnumerator LoadNextGame()
{
    if(SceneManager.GetActiveScene().name=="Basket")
    {
        yield return new WaitForSeconds(TransTime);
        TimerUp=false;
        CurrentTime=0f;
         HastLoad=false;
        SceneManager.LoadScene("Ink");
    }
    if(SceneManager.GetActiveScene().name=="Ink")
    {
        yield return new WaitForSeconds(TransTime);
         TimerUp=false;
         CurrentTime=0f;
          HastLoad=false;
        SceneManager.LoadScene("Broom");
    }
    if(SceneManager.GetActiveScene().name=="Broom")
    {
        yield return new WaitForSeconds(TransTime);
         TimerUp=false;
         CurrentTime=0f;
          HastLoad=false;
        SceneManager.LoadScene("Basket");
    }
}

}

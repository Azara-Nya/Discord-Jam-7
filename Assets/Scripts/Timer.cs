using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Timer : MonoBehaviour
{
    public bool TimerUp;
    public bool CanDo=true;
    public int health=3;
    public int score;
    public bool OffMenu=false;
    [SerializeField] float MaxTime;
    [SerializeField] private float TransTime=1f;
    [SerializeField] private GameObject GamePanel;
    [SerializeField] private TextMeshProUGUI ScoreText;
    [SerializeField] private GameObject[] hearts;
    [SerializeField] private GameObject GameOverDisplay;
    public GameObject[] SFX;
    private bool HastLoad;
    private float CurrentTime;
    private int counter;
    private int counterlast;


void Awake()
{
    DontDestroyOnLoad(this.gameObject);
}
    void Update()
    {
        if(OffMenu)
    {
        if(health==3)
        {
           GamePanel.SetActive(true);
        }
        if(CanDo)
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
            SFX[0].SetActive(true);
        }
        if(health ==1)
        {
            hearts[1].SetActive(false);
            SFX[1].SetActive(true);
        }
        if(health<=0)
        {
            hearts[0].SetActive(false);
            SFX[2].SetActive(true);
            GameOverDisplay.SetActive(true);
            CanDo = false;
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
    }
    }
public IEnumerator LoadNextGame()
{
    if(SceneManager.GetActiveScene().name=="Basket")
    {
        yield return new WaitForSeconds(TransTime);
        TimerUp=false;
        CurrentTime=0f;
         HastLoad=false;
         CanDo=true;
        SceneManager.LoadScene("Ink");
    }
    if(SceneManager.GetActiveScene().name=="Ink")
    {
        yield return new WaitForSeconds(TransTime);
         TimerUp=false;
         CurrentTime=0f;
          HastLoad=false;
          CanDo=true;
        SceneManager.LoadScene("Broom");
    }
    if(SceneManager.GetActiveScene().name=="Broom")
    {
        yield return new WaitForSeconds(TransTime);
         TimerUp=false;
         CurrentTime=0f;
          HastLoad=false;
          CanDo=true;
          MaxTime-=1;
        SceneManager.LoadScene("Basket");
    }
}

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;

public class InkManager : MonoBehaviour
{
    public bool[] IsInked;
    Timer Tim;
    private bool addedScore;
    [SerializeField] private AudioSource SFX;

void Start()    
{
    Canvas Can = FindObjectOfType<Canvas>();
    Tim = Can.GetComponent<Timer>();
} 
    void Update()
    {
        if(IsInked[0] && IsInked[1])
        {
            if(IsInked[2] && IsInked[3])
            {
                if(IsInked[4])
                {
                    Tim.CanDo=true;
                    if(!addedScore)
                    {
                    Tim.score++;
                    SFX.Play();
                    addedScore = !addedScore;
                    }
                    StartCoroutine(Tim.LoadNextGame());
                }
            }
        }
    }
}

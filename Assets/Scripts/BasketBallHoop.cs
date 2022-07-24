using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;

public class BasketBallHoop : MonoBehaviour
{
    [SerializeField] private GameObject Ball;
    [SerializeField] private Timer Tim;
    [SerializeField] private AudioSource SFX;


void Start()    
{
    Canvas Can = FindObjectOfType<Canvas>();
    Tim = Can.GetComponent<Timer>();
} 
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("BasketBall"))
        {
            Destroy(Ball);
            SFX.Play();
            Tim.CanDo=false;
            Tim.score++;
            StartCoroutine(Tim.LoadNextGame());
        }
    }
}

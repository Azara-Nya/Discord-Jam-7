using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketBallHoop : MonoBehaviour
{
    [SerializeField] private GameObject Ball;
    [SerializeField] private Timer Tim;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("BasketBall"))
        {
            Destroy(Ball);
            Tim.CanDo=false;
            StartCoroutine(Tim.LoadNextGame());
            Debug.Log("Ya done good");
        }
    }
}

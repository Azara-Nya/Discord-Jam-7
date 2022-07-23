using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketBallHoop : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("BasketBall"))
        {
            Debug.Log("Ya done good");
        }
    }
}

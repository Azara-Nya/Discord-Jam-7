using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InkCheckPoints : MonoBehaviour
{
    public InkManager im;
    [SerializeField] private int Index;

 void OnTriggerEnter2D(Collider2D other)
 {
    if(other.CompareTag("Ink"))
    { 
        im.IsInked[Index]=true;
    }
 }
}
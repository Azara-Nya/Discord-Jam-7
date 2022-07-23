using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InkCheckPoints : MonoBehaviour
{
    public InkManager im;
    [SerializeField] private int Index;

 void OnMouseOver()  
    {
        im.IsInked[Index]=true;  
    }
}

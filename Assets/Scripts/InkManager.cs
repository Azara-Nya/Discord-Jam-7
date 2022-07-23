using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InkManager : MonoBehaviour
{
    public bool[] IsInked;
    void Update()
    {
        if(IsInked[0] && IsInked[1])
        {
            if(IsInked[2] && IsInked[3])
            {
                if(IsInked[4])
                {
                    StartCoroutine(Ender());
                }
            }
        }
    }

    IEnumerator Ender()
    {
        Debug.Log("Ya did it!");
        yield return new WaitForSeconds(0f);
    }
}

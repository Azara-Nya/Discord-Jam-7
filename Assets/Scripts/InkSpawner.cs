using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InkSpawner : MonoBehaviour
{
    [SerializeField] private GameObject InkPrefab;

    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            StartCoroutine(Inked());
        }
    }

    IEnumerator Inked()
    {
         Vector3 mousePos = Input.mousePosition;
         mousePos.z = 2.0f;    
         Vector3 objectPos = Camera.main.ScreenToWorldPoint(mousePos);
         Instantiate(InkPrefab, objectPos, Quaternion.identity);
        yield return new WaitForSeconds(1f);
    }
}

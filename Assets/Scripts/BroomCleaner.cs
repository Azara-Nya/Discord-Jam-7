using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BroomCleaner : MonoBehaviour
{

    [SerializeField] private float maxTime=2f;
    [SerializeField] private GameObject SpawnerPoint1;
    [SerializeField] private GameObject SpawnerPoint2;
    [SerializeField] BroomCleaner Rub;
    [SerializeField] Broom bm;
    private float timer;
    bool AdvanceTime;


    void Start()
    {
        bm = FindObjectOfType<Broom>();
    }
    void Update()
    {
        if(AdvanceTime)
        {
            if(timer >= maxTime)
            {
                bm.Counter++;
                if(bm.Counter==1)
                {
                    Instantiate(Rub, SpawnerPoint1.transform.position, Quaternion.identity);
                }
                if(bm.Counter==2)
                {
                    Instantiate(Rub, SpawnerPoint2.transform.position, Quaternion.identity);
                }

                Destroy(gameObject);
            }
            else
            {
                timer += Time.fixedDeltaTime;
            }
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Broom"))
        {
            AdvanceTime = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if(other.CompareTag("Broom"))
        {
            AdvanceTime = false;
        }
    }

}

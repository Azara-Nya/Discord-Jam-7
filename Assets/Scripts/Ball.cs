using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private bool isFlung;
    [SerializeField] private float speed = 1f;
    [SerializeField] private Transform target;
    [SerializeField] private Transform ShootingPoint;
    [SerializeField] private Rigidbody2D rb;

    void Update()
    {
        if(!isFlung)
        {
            var step = speed * Time.fixedDeltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);

            if (Vector3.Distance(transform.position, target.position) < 0.001f)
            {
            target.position *= -1.0f;
            }
        }
        if(Input.GetButtonDown("Fire1"))
        {
            isFlung=true;
            rb.AddForce(ShootingPoint.up * (speed*10), ForceMode2D.Impulse);
        }
    }

}

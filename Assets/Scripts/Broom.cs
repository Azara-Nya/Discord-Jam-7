using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Broom : MonoBehaviour
{
    public int Counter;
[SerializeField] private Rigidbody2D rb;
[SerializeField] private float moveSpeed=5f;
    Vector2 movement;
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        //Slidly Movement (hopefully) in future!    

        if(Counter == 3)
        {
            Debug.Log("Yayyy it's clean!");
        }
    }
}

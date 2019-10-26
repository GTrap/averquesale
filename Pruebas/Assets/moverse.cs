using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moverse : MonoBehaviour
{
   public Rigidbody2D rb;
   public float FuerzaSalto;


    void Start()
    {
       rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
         if (Input.GetButton("d")) {
            rb.velocity = new Vector2(10, rb.velocity.y);
         }
         if (Input.GetButton("a")) {
            rb.velocity = new Vector2(-10, rb.velocity.y);
         }
         if (Input.GetButtonDown("w")) {
            rb.AddForce(new Vector3(0, 1, 0) * FuerzaSalto);
         }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
   public Rigidbody2D rb;
   public float FuerzaSalto;
   bool salto;


    void Start()
    {
       rb = GetComponent<Rigidbody2D>();
       salto = false;
    }


    void Update()
    {
         if (Input.GetButton("d")) {
            rb.velocity = new Vector2(10, rb.velocity.y);
         }
         if (Input.GetButton("a")) {
            rb.velocity = new Vector2(-10, rb.velocity.y);
         }
         if (Input.GetButtonDown("w") && salto ) {
            rb.AddForce(new Vector3(0, 2, 0) * FuerzaSalto);
            salto = false;
         }
         
    }
   void OnCollisionEnter2D(Collision2D other){
         if (other.gameObject.name == "buen suelo") {
            
            salto = true;
 
         }
   }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
   public Rigidbody2D rb;
   public float FuerzaSalto;
   public float velocidad;
   bool salto;
   


    void Start()
    {
       rb = GetComponent<Rigidbody2D>();
       salto = false;
    }

   void Update()
   {

   }

    void FixedUpdate()
    {
       /*
         if (Input.GetButton("d")) {
            rb.velocity = new Vector2(10, rb.velocity.y);
         }
         if (Input.GetButton("a")) {
            rb.velocity = new Vector2(-10, rb.velocity.y);
         }
         
         */
         rb.velocity=new Vector2((velocidad * Input.GetAxis("Horizontal")), (rb.velocity.y));
         
         if(Input.GetAxis("Horizontal")<0){
            GirarseIzquierda();
         }
         if(Input.GetAxis("Horizontal")>0){
            GirarseDerecha();
         }

         if (Input.GetButtonDown("w") && salto ) {
            rb.AddForce(new Vector3(0, 1, 0) * FuerzaSalto);
         }
    }
   void OnCollisionExit2D(Collision2D other){
         if (other.gameObject.name == "buen suelo") {
            
            salto = false;
 
         }
   }
   void OnCollisionEnter2D(Collision2D other){
         if (other.gameObject.name == "buen suelo") {
            
            salto = true;
 
         }
   }
   void GirarseIzquierda (){
      this.gameObject.transform.localScale = new Vector3(-1,1,1);
   }
   void GirarseDerecha(){
      this.gameObject.transform.localScale = new Vector3(1,1,1);
   }

}

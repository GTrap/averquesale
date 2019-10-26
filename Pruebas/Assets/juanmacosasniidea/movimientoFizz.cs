using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoFizz : MonoBehaviour
{
    Rigidbody2D rb;
    public float velocidad;

    void Start()
    {

        rb = GetComponent<Rigidbody2D> ();
    }

    void Update (){

    }

    void FixedUpdate()
    {
        rb.velocity=new Vector2((velocidad * Input.GetAxis("Horizontal")), (rb.velocity.y));
        
        if(Input.GetAxis("Horizontal")<0){
            GirarseIzquierda();
         }
         if(Input.GetAxis("Horizontal")>0){
            GirarseDerecha();
         }
    }


    void GirarseIzquierda (){
      this.gameObject.transform.localScale = new Vector3(-1,1,1);
   }
   void GirarseDerecha(){
      this.gameObject.transform.localScale = new Vector3(1,1,1);
   }
}

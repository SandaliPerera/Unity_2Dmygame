using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mace_die : MonoBehaviour
{
    public float die_time = 1.2f;
    public float MaceDie_time = 8f;
    
     Rigidbody2D rb;
    

    
    void Update()
    {
        //start rolling
        if (Info.activateBall)
        {
            rb = GetComponent<Rigidbody2D>();
            rb.AddForce(new Vector2(-10500f, 0f));
            Info.activateBall = false;
            Destroy(this.gameObject, MaceDie_time);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            Info.die = true;
            Destroy(collision.gameObject, die_time);
        }
    }
}   

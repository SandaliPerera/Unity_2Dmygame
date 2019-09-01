using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterDie1 : MonoBehaviour
{
    public float WaterDie_time = 1.2f;

    



   

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            Info.die = true;
            Destroy(collision.gameObject, WaterDie_time);
        }
    }
}

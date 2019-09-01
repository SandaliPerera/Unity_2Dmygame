using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mace : MonoBehaviour
{
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Info.Health = Info.Health - 4;
            Info.Mace_hit = true;
            


            if (Info.Health <= 0)
            {
                Info.die = true;
               Destroy(collision.gameObject, 1.2f);
            }
            Debug.Log("Health = " + Info.Health);

        }
    }
}

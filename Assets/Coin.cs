using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    

    public GameObject player;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Info.coin_marks++;
            Destroy(this.gameObject);
            Debug.Log("Coins = " + Info.coin_marks);
            
        }
    }
}

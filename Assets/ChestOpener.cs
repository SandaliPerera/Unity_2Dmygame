using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestOpener : MonoBehaviour
{
    public Animator animator;
    bool open = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            open = true;
            animator.SetBool("open", open);
            open = false;
            Info.coin_marks = Info.coin_marks + 5;
            Debug.Log("Coins = " + Info.coin_marks);
        }
    }
}

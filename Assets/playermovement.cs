using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public CharacterController2D Controller;

    public float horizontalmove = 0f;
    public Animator animator;
    public float speed = 40f;
    public bool jump = false;
    Rigidbody2D rb;
    // Update is called once per frame
    void Update()
    {
       horizontalmove = Input.GetAxisRaw("Horizontal") * speed;
     
        animator.SetFloat("speed",Mathf.Abs(horizontalmove));
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("isJump", true);
        }

        //die animation
        if (Info.die)
        {
            animator.SetBool("die", true);
        }
    }

    public void onLanding()
    {
        animator.SetBool("isJump", false);

    }

    private void FixedUpdate()
    {
        //move the player
        Controller.Move(horizontalmove * Time.fixedDeltaTime, false, jump);
        jump = false;

        //force when touch mace
        if (Info.Mace_hit)
        {
             rb = GetComponent<Rigidbody2D>();
             rb.AddForce(new Vector2((horizontalmove + 10f) * -70f,0f));
            Info.Mace_hit = false;

        }
        
    }
}

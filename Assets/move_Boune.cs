using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_Boune : MonoBehaviour
{
    public Rigidbody2D rb;
    public float up = 100f;
    // Start is called before the first frame update
    void Start()
    {
        
       // rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float movex = Input.GetAxis("Horizontal");
       // float movey = Input.GetAxis("Vertical");
        if (movex > 0)
        {
            transform.position = transform.position + new Vector3(0.1f,0f,0f);
        }
        if (movex < 0)
        {
            transform.position = transform.position + new Vector3(-0.1f, 0f, 0f);
        }
        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(new Vector2(0f, up));
        }
    }
}

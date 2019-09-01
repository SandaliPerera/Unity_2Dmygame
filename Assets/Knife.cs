using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife : MonoBehaviour
{
    public Rigidbody2D rb;
    public float Speed = -50f;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = Vector2.right * Speed * Input.GetAxisRaw("Horizontal");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

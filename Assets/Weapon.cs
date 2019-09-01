using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform knifePrefab;
    public Transform firePoint;

    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
            //animator.SetBool("fire",true);
           
        }
    }

    void Shoot()
    {
        Instantiate(knifePrefab, firePoint.position, firePoint.rotation);

        //animator.SetBool("fire",true);
    }
}

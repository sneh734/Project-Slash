using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water_Princess_Interactions : MonoBehaviour
{
    public Animator animator;
    public bool isAttacking = false;
    public static Water_Princess_Interactions instance;

   
    private void Awake()
        {
            instance = this;
        }

    // Update is called once per frame
    void Update()
    {
        Attack();

        if(Input.GetKeyDown(KeyCode.R))
            {   
                    animator.Play("Ultimate");
            }
        
    }

     void Attack()
        {
            if(Input.GetButtonDown("Fire1") && !isAttacking)
            {
                isAttacking = true;
            }
        }
}

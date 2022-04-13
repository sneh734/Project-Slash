using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Air_Bender_Interactions : MonoBehaviour
{

    public Animator animator;
    public bool isAttacking = false;
    public static Air_Bender_Interactions instance;
    // Start is called before the first frame update


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

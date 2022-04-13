using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireHeroInteractions : MonoBehaviour
{
    public Animator animator;
    public bool isAttacking = false;
    public static FireHeroInteractions instance;
    


    private void Awake()
        {
            instance = this;
        }





    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Attack(); 

        if(Input.GetKeyDown(KeyCode.R))
            {   
                    animator.Play("Fire Hero Ultimate");
                    while(Input.GetKeyUp(KeyCode.R) == true)
                    {
                            
                    } 
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

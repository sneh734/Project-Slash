using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kings_Interactions : MonoBehaviour
{
    public Animator LightAttack;
    public Animator animator;
    public Animator HeavyAttack;
    float nextAttackTimeL = 0f;   
    float nextAttackTimeH = 0f;
    public float AttackDamageL = 1f;
    public float AttackDamageH = 5f; 
    bool isAttacking = false;
    bool isAttacking3 = false;
    
    // Update is called once per frame
    void Update()
    {
        if(Time.time >= nextAttackTimeL)
        {
        
            if(Input.GetMouseButtonDown(0) && !isAttacking)
            {
                isAttacking = true;
                animator.Play("King Attack 1");
                StartCoroutine(WaitAttack());

            }
        }

        IEnumerator WaitAttack()
            {
                
                yield return new WaitForEndOfFrame();
                isAttacking = false;
            }

        if(Time.time >= nextAttackTimeH)
        {

            if(Input.GetMouseButtonDown(1) && !isAttacking3)
            {
                isAttacking3 = true;
                animator.Play("King attack 3");
                StartCoroutine(WaitAttack3());
            }
        }

        IEnumerator WaitAttack3()
            {
                yield return new WaitForSecondsRealtime(1f);
                isAttacking3 = false;
            }
        
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public float attackcooldown;
    public float damage;
    public float range;
    public float colliderDistance;
        public BoxCollider2D boxCollider;
    public LayerMask playerlayer;
    bool alreadyAttacking;
   
   
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.CompareTag("Player") & Enemy.instance.isdead == false)
        {
            alreadyAttacking = true;

            if (alreadyAttacking)
            {
                alreadyAttacking = false;
                Enemy.instance.animator.Play("Attack1");
                other.GetComponent<CharacterHealth>().TakeDamage(damage);

            }
        }
    }

 


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttackEW : MonoBehaviour
{
    public float attackcooldown;
    public float damage = 0.1f;
    public float range;
    public float colliderDistance;
    public BoxCollider2D boxCollider;
    public LayerMask playerlayer;

    
    public void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            EvilWizardEnemy.instance.animator.Play("Attack");
            other.GetComponent<CharacterHealth>().TakeDamage(0.1f);

            if(EvilWizardEnemy.instance.currentHealth <= 0f)
            {
                other.GetComponent<CharacterHealth>().KillOnHeal("Heal");

                    Debug.Log("healed");
            }
            
        }  


    }
}

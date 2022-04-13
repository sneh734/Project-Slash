using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackSkeleton : MonoBehaviour
{
    public float attackcooldown;
    public float damage = 0.05f;
    public float range;
    public float colliderDistance;
    public BoxCollider2D boxCollider;
    


    public void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            SkeletonEnemy.instance.animator.Play("Attack");
            other.GetComponent<CharacterHealth>().TakeDamage(damage);

        }


    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackMSH : MonoBehaviour
{
    public float attackcooldown;
    public float damage = 0.005f;
    public float range;
    public float colliderDistance;
    public BoxCollider2D boxCollider;
    public LayerMask playerlayer;


    public void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            MushroomEnemy.instance.animator.Play("Attack");
            other.GetComponent<CharacterHealth>().TakeDamage(damage);

            

        }


    }
}

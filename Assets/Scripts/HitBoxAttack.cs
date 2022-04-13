using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class HitBoxAttack : MonoBehaviour
{

    public float Damage;
    public static HitBoxAttack instance;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Enemy"))
            {
              other.GetComponent<Enemy>().TakeDamage(Damage);
                             
            }

        if (other.CompareTag("Enemy EW"))
        {
            other.GetComponent<EvilWizardEnemy>().TakeDamage(Damage);
        }

        if (other.CompareTag("EnemySK"))
        {
            other.GetComponent<SkeletonEnemy>().TakeDamage(Damage);
        }

        if (other.CompareTag("EnemyGB"))
        {
            other.GetComponent<GoblinoEnemy>().TakeDamage(Damage);

        }

        if (other.CompareTag("EnemyMSH"))
        {
            other.GetComponent<MushroomEnemy>().TakeDamage(Damage);

        }

    }

}

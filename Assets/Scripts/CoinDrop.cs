using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinDrop : MonoBehaviour
{
    public GameObject Coin;
    public Transform transform;
    public float HealthChecker;
    private bool alreadyExe = false;
    //public float Knight = Enemy.instance.currentHealth;
   // public float Wizard= EvilWizardEnemy.instance.currentHealth;


   

    // Update is called once per frame
    void Update()
    {
        
        
        if (Enemy.instance.currentHealth <= 0f)
        {
            if (!alreadyExe)
            {
                CoinDrops();
                alreadyExe = true;
            }
        }
        if (EvilWizardEnemy.instance.currentHealth <= 0f)
        {
            if (!alreadyExe)
            {
                CoinDrops();
                alreadyExe = true;
            }
        }

    }
    void CoinDrops()
    {
            Vector2 position = transform.position;
            GameObject coin = Instantiate(Coin, position + new Vector2(0.0f, 0.0f), Quaternion.identity);

              
    }

}

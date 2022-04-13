using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpDrop : MonoBehaviour
{
    public GameObject EXP_Orb;
    public Transform transforms;
    public float HealthCchecker;
    private bool alreadyExe = false;
    void Update()
    {
        if (Enemy.instance.currentHealth <= 0f)
        {
            if (!alreadyExe)
            {
                ExpDrops();
                alreadyExe = true;
            }

        }
    }

    void ExpDrops()
    {
        Vector2 position = transforms.position;
        GameObject exp_orb = Instantiate(EXP_Orb, position + new Vector2(0.0f, 0.0f), Quaternion.identity);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterHealth : MonoBehaviour
{
    [SerializeField]
    public float PlayerHealth = 1f;
    public float CurrentHealth;
    public Image fill;
    public static CharacterHealth instance;
    bool alreadyCalled = false;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        if (alreadyCalled == false)
        {
            CurrentHealth = PlayerHealth;
            alreadyCalled = true;
            fill.fillAmount = CurrentHealth;

        }
    }

    // Update is called once per frame
    void Update()
    {
        fill.fillAmount = CurrentHealth;
    }

    public void TakeDamage(float damage)
    {
        CurrentHealth = CurrentHealth - damage;

        animator.Play("Hurt");

        fill.fillAmount = CurrentHealth;
      
        
        
    }

    public void KillOnHeal(string Heal)
    {
        if (Heal == "heal")
        {
            CurrentHealth = CurrentHealth + 0.5f;

            fill.fillAmount = CurrentHealth;
        }
    }

    public void LoseHealth(int value)
    {
      
    }

}


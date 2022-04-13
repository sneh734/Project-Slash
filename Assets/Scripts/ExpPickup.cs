using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExpPickup : MonoBehaviour
{
    public static ExpPickup instance;
   
  
    public float minExprience = 0f;
    public float currentExprience;
    private int exp = 60;
    public Slider slider;
    bool alreadyCalled = false;
    public int level = 1;
    
    private void Start()
    {
        if (alreadyCalled == false)
        {
            currentExprience = minExprience;

            alreadyCalled = true;

        }
    }


    
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("EXP"))
            {

                 GiveExp(exp);
                 Destroy(other.gameObject);
                
                
            }
        }

    void GiveExp(int exp)
    {
       
        currentExprience = currentExprience + exp;

        slider.value = currentExprience;

        while(currentExprience >= 100)
        {
            UpdateExp();

            if (currentExprience < 100)
                break;
                
            
        }
        

    }
 
    void UpdateExp()
    {
        if (currentExprience >= 100)
        {
            LevelUp();
            currentExprience = currentExprience - 100;
            slider.value = currentExprience;

            
        }
        
        
        if (currentExprience <= 100)
        {
            slider.value = currentExprience;

        }

    }
    
    void LevelUp()
    {
        level = level + 2;

    }
}

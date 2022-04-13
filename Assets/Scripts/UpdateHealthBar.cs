using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateHealthBar : MonoBehaviour
{


    public Image fill;
    public float UpdateHealth;
    public static UpdateHealthBar instance;

    private void Start()
    {
        
    }
    private void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    public void UpdateHealthB(float H)
    {
       
        fill.fillAmount = H;
    }
}
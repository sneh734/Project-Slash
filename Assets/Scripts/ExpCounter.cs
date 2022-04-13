using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExpCounter : MonoBehaviour
{
    public static ExpCounter instance;
    public TextMesh text;
    int Levels;

    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
    }


    public void ChangeExp()
    {
        Levels = ExpPickup.instance.level;
        text.text = Levels.ToString();
    }

}

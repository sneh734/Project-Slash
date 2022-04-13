using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpValue : MonoBehaviour
{
    public static ExpValue instance;
    public int Expvalue = 40;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("Attack"))
        {

            //ExpCounter.instance.ChangeScore(Expvalue);

        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryPopup : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 0.3f);
        //transform.localPosition = new Vector3(0, 0.5f , 0);
    }
}
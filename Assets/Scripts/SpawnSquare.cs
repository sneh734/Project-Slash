using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSquare : MonoBehaviour
{
    private Vector3 startPosition;
    public static SpawnSquare instance;

    public GameObject[] gameObjectSet;


int counter = 2;


void Start () {

startPosition = transform.position;
}
void SpawnRandomObject() {
int whichItem = Random.Range (0, 1);



GameObject myObj = Instantiate(gameObjectSet[whichItem]) as GameObject;

myObj.transform.position = transform.position;

if(MushroomEnemy.instance.currentHealth <= 0)
{
    Destroy(myObj, 0.5f);
}



}

// Update is called once per frame
void Update () {

if(counter >= 1)
{
     --counter;
    SpawnRandomObject ();
}

}
}

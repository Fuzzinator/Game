using UnityEngine;
using System.Collections;

public class Interact : MonoBehaviour {

    public GameObject friend;
    public GameObject foe;

    
    

    void OnTriggerEnter(Collider col)
    {
        //print("triggering");
        if (col.name == "Friend")
        {
            friend.GetComponent<AverageShmo>().Talk();
        }
        if (col.name == "Foe")
        {
            print("Enemy!!!");
        }

    }

}

using UnityEngine;
using System.Collections;

public class Interact : MonoBehaviour {

    public GameObject friend;
    public GameObject foe;

    void OnTriggerEnter(Collider col)
    {
        if (col == friend)
        {
            print("Friend");
        }
        if (col == foe)
        {
            print("Enemy!!!");
        }
    }

}

using UnityEngine;
using System.Collections;

public class Enemies : MonoBehaviour {

    public int i;
    public int health;

	// Use this for initialization
	void Start () {
        health = 20;
        i = 0;
    }
	
	// Update is called once per frame
	void Update () {

 
         
	}

    public void hurtPlayer()
    {
        if (i <= health)
        {
            i++;
            print("you have lost a health! Now you have " + (health - i) + " health");
        }
    }

    public void declareStuff()
    {
        print("I am your enemy and am here to hurt you!");

    }
}

using UnityEngine;
using System.Collections;
using System;

public class Delegates : MonoBehaviour {

    public int health = 100;

    //Actions are a type of deligate. Deligates contain functions just as vars contain data
    Action DisplayHealth;
    Action KillPlayer;
    Action EndGame;


	// Use this for initialization
	void Start () {

        //assign function DisplayHealthHandler to action DisplayHealth
        DisplayHealth = DisplayHealthHandler;

	}
    
    void DisplayHealthHandler()
    {
        print("health is good");
        //unassign all functions from DisplayHealth
        DisplayHealth = null;
        KillPlayer = KillPlayerHandler;

    }

    void KillPlayerHandler()
    {
        health--;
        if (health <= 0)
        {
            KillPlayer = null;
            EndGame = EndGameHandler;
        }
        if (health > 0)
        print("You are dying. Your health is : " + health);


    }

    void EndGameHandler()
    {
        print("You suck and are dead");
        EndGame = null;

    }
    // Update is called once per frame
    void Update () {
        //check if DisaplayHealth has a function assigned
        //if nothing assigned DisplayHealth wont run
        if(DisplayHealth != null)
        DisplayHealth();

        if (KillPlayer != null)
            KillPlayer();

        if (EndGame != null)
            EndGame();
	}
}

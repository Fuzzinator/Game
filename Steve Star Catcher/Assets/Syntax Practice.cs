using UnityEngine;
using System.Collections;

public class SyntaxPractice : MonoBehaviour {
    //declair a bool called doostuff and set it to false.
    bool dooStuff;

	// Use this for initialization
	void Start () {
        //this bool now is set to true as in yes. meaning that it will now do stuff.
	dooStuff = true;
	}
	
    //This is a function called stuff it relys on the bool doostuff
    void SomeStuff()
    {
        //checks to see if doostuff is true
        if (dooStuff == true)
        {   //now its gonna print some stuff
            print("I am doing some stuff!");
        }//if doostuff is not true
        else
            //we're gonna print words
            print("No! I dont want to do anything!");
            //and now more words
            print("... Oh fine!");
            //and finally set doostuff to true
            dooStuff = true;
            



    }
	// Update is called once per frame
	void Update () {
        //on update call function somestuff
        SomeStuff();
	}
}

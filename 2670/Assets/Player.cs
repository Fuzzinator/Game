using UnityEngine;
using System.Collections;


public class Player : HumanBase {

    

	// Use this for initialization
	public override void Start () {
        base.Start();

        for (int i = 0; i < StaticVars.addScore; i++)
        {
            characteristics[Random.Range(0, 3)]++;

        }

        strength = characteristics[0];
        perception = characteristics[1];
        intelligence = characteristics[2];
        dexterity = characteristics[3];

        print("Your characters base stats are: " + strength + " " + perception + " " + intelligence + " " + dexterity);
        
        

	}
	
}

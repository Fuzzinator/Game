using UnityEngine;
using System.Collections;

public class Player : HumanBase {

	// Use this for initialization
	public override void Start () {
        base.Start();

        print("Your characters base stats are: " + strength + " " + perception + " " + intelligence + " " + dexterity);

        print("do other stuff");
        

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

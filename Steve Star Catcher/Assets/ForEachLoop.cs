using UnityEngine;
using System.Collections;

public class ForEachLoop : MonoBehaviour {

    public string[] powerUps = { "Health", "Ammo", "Shields", "Magic" };

	// Use this for initialization
	void Start () {

        foreach (string _powerUps in powerUps)
        {
            print("I found a " + _powerUps + "power-up on my way to grandmas");

        }
	}
	
}

using UnityEngine;
using System.Collections;
using System;

public class DamagingPowerUp : MonoBehaviour, IDamage {

    public void Damage()
    {
        print("you damaged player");
    }

	// Use this for initialization
	void Start () {
        Damage();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

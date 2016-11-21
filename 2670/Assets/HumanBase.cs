using UnityEngine;
using System.Collections;
using System;

public class HumanBase : MonoBehaviour, IAttack, IDamage {

    public int strength;
    public int perception;
    public int intelligence;
    public int dexterity;



    public virtual void Attack()
    {
        throw new NotImplementedException();
    }

    public virtual void Damage()
    {
        throw new NotImplementedException();
    }

    // Use this for initialization
    public virtual void Start () {
        strength = 5;
        perception = 5;
        intelligence = 5;
        dexterity = 5;

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

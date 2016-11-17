using UnityEngine;
using System.Collections;
using System;

public class HumanBase : MonoBehaviour, IAttack, IDamage {

    public void Attack()
    {
        throw new NotImplementedException();
    }

    public void Damage()
    {
        throw new NotImplementedException();
    }

    // Use this for initialization
    public virtual void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

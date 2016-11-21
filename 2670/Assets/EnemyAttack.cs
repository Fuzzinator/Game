using UnityEngine;
using System.Collections;
using System;

public class EnemyAttack : MonoBehaviour, IAttack, IDamage {

    public void Attack()
    {
        print("attack player");
    }

    public void Damage()
    {
        print("damage player");
    }

    // Use this for initialization
    void Start () {
	
	}
	
}

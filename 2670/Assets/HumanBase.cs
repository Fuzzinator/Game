using UnityEngine;
using System.Collections;
using System;

public class HumanBase : MonoBehaviour, IAttack, IDamage, ITalk {

    public int[] characteristics;
    public int strength;
    public int perception;
    public int intelligence;
    public int dexterity;
    public int speed;


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

        characteristics = new int[] { 5, 5, 5, 5 };

        strength = characteristics[0];
        perception = characteristics[1];
        intelligence = characteristics[2];
        dexterity = characteristics[3];

        speed = dexterity;

    }

    public void Talk()
    {
        print("Grunt");
    }
}

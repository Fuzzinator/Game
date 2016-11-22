using UnityEngine;
using System.Collections;
using System;

public class HumanBase : MonoBehaviour, IAttack, IDamage, ITalk {

    public int[] characteristics;
    public static int strength;
    public static int perception;
    public static int intelligence;
    public static int dexterity;
    public static int speed;
    public static int charisma;


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

        characteristics = new int[] { 5, 5, 5, 5, 5 };

        strength = characteristics[0];
        perception = characteristics[1];
        intelligence = characteristics[2];
        dexterity = characteristics[3];
        charisma = characteristics[4];

        speed = dexterity;

    }

    public virtual void Talk()
    {
        print("Grunt");
    }
}

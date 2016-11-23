using UnityEngine;
using System.Collections;
using System;

public class EnemyAttack : MonoBehaviour, IAttack, IDamage {

    public int percentHit;
    public int hitPlayer = 5;
    public int numAttacks = AverageEnemy.dexterity / 2;
    public int i;

    public GameObject player;

    public void Attack()
    {

        print("attack player");
        while ( i < numAttacks)
        {
            switch (Player.dexterity)
            {
                case 5:
                    hitPlayer = UnityEngine.Random.Range(0, 10);
                    if (Player.dexterity <= hitPlayer)
                    {
                        Damage();
                       
                    }else
                    {
                        print("Phew! The attack missed!");
                    }
                    break;
                case 6:
                    percentHit = UnityEngine.Random.Range(Player.dexterity - 5, Player.dexterity + 5);
                    if (Player.dexterity <= hitPlayer)
                    {
                        Damage();
                    }
                    else
                    {
                        print("Phew! The attack missed!");
                    }
                    break;
                case 7:
                    hitPlayer = UnityEngine.Random.Range(Player.dexterity - 3, Player.dexterity + 7);
                    if (Player.dexterity <= hitPlayer)
                    {
                        Damage();
                    }
                    else
                    {
                        print("Phew! The attack missed!");
                    }
                    break;
                case 8:
                    percentHit = UnityEngine.Random.Range(Player.dexterity - 2, Player.dexterity + 8);
                    if (Player.dexterity >= hitPlayer)
                    {
                        Damage();
                    }
                    else
                    {
                        print("Phew! The attack missed!");
                    }
                    break;
                case 9:
                    hitPlayer = UnityEngine.Random.Range(Player.dexterity - 1, Player.dexterity + 9);
                    if (Player.dexterity <= hitPlayer)
                    {
                        Damage();
                    }
                    else
                    {
                        print("Phew! The attack missed!");
                    }
                    break;
                case 10:
                    percentHit = UnityEngine.Random.Range(Player.dexterity, Player.dexterity + 10);
                    if (Player.dexterity >= hitPlayer)
                    {
                        Damage();
                    }
                    else
                    {
                        print("Phew! The attack missed!");
                    }
                    break;
                }
            i++;
        }
        i = 0;
        player.GetComponent<Player>().Attack();   
    }

    public void Damage()
    {

        print("Ouch! Enemy hits you for " + AverageEnemy.strength + " damage!");
        
    }

}

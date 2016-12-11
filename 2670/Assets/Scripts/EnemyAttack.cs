using UnityEngine;
using System.Collections;
using System;

public class EnemyAttack : MonoBehaviour, IAttack, IDamage {

    public int percentHit;
    public int hitPlayer = 5;
    public int numAttacks = AverageEnemy.dexterity / 2;
    public int i;
    public static int[] damages;
    public int attackNum = 0;

    public GameObject player;

    public void Attack()
    {
        for(int j = 0; j < numAttacks; j++)
        {
            damages[j] = (int)(AverageEnemy.strength * (UnityEngine.Random.Range(0.5f, 1.5f)));
        }


        while ( i < numAttacks)
        {
            foreach (int attacks in damages)
            {
                switch (Player.dexterity)
                {
                    case 5:
                        hitPlayer = UnityEngine.Random.Range(0, 10);
                        if (Player.dexterity <= hitPlayer)
                        {
                            Damage();

                        }
                        else
                        {
                            print("Phew! The attack missed!");
                        }
                        StartCoroutine(AverageEnemy.SmallPause());
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
                        StartCoroutine(AverageEnemy.SmallPause());
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
                        StartCoroutine(AverageEnemy.SmallPause());
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
                        StartCoroutine(AverageEnemy.SmallPause());
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
                        StartCoroutine(AverageEnemy.SmallPause());
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
                        StartCoroutine(AverageEnemy.SmallPause());
                        break;
                }
            }
            i++;
            attackNum++;
        }
        i = 0;
        attackNum = 0;


        player.GetComponent<Player>().Attack(this.gameObject);   
    }

    public void Damage()
    {
        
        print("Ouch! Enemy hits you for " + damages[attackNum] + " damage!");
        
    }



}

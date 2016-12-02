using UnityEngine;
using System.Collections;

public class Interact : MonoBehaviour {

    public GameObject player;
    public GameObject friend;
    public GameObject foe;

    
    

    void OnTriggerEnter(Collider col)
    {
        //print("triggering");
        if (col.name == "Friend")
        {
            friend.GetComponent<AverageShmo>().Talk();
        }
        if (col.name == "Foe")
        {
            //if (AverageEnemy.dexterity > Player.dexterity)
            //{
            //   // if{(AverageEnemy.health <= 0)
            //            { }
               foe.GetComponent<AverageEnemy>().Attack();
            }
            else if(AverageEnemy.dexterity < Player.dexterity )
            {
                player.GetComponent<Player>().Attack(col.gameObject);
            }
        }

    }

//}

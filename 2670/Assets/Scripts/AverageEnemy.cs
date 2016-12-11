using UnityEngine;
using System.Collections;

public class AverageEnemy : HumanBase {

    private int scoreIncrease;
    private int charCounter;
    private int chngScore = 5;

    public bool tired = false;

    // Use this for initialization
    public override void Start()
    {
        base.Start();

        //Recycle.SendToGenerator += AddToList;

        CountEnemies.enemies.Add(gameObject);

        for (int i = 0; i < chngScore; i++)
        {
            charCounter = UnityEngine.Random.Range(0, 4);
            scoreIncrease = UnityEngine.Random.Range(-2, 2);
            characteristics[charCounter] += scoreIncrease;

            //if (characteristics[scoreIncrease] > 10)
            //{
            //    characteristics[i]--;
            //    chngScore++;
            //}

        }

        strength = characteristics[0];
        perception = characteristics[1];
        intelligence = characteristics[2];
        dexterity = characteristics[3];
        charisma = characteristics[4];

        print("Your enemy's base stats are: Strength:" + strength + " Perception:" + perception
           + " Intelligence:" + intelligence + " Dexterity:" + dexterity + " Charisma:" + charisma);

         

        
    }

    public override sealed void Attack()
    {
        if (!tired)
        {
            tired = true;
            print("The enemy attacks!");
            StartCoroutine(SmallPause());
            this.GetComponent<EnemyAttack>().Attack();
           
        }
        StartCoroutine(TiredCounter());

    }

    IEnumerator TiredCounter()
    {
        yield return new WaitForSeconds(2);
        tired = false;
    }

    public static IEnumerator SmallPause()
    {
        yield return new WaitForSeconds(1);
    }


    //private void AddToList(NavAgent obj)
    //{
    //    RecycleList.Add(obj);
    //    obj.transform.position = spawner.position
    //}
}

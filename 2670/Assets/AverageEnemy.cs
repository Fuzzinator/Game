using UnityEngine;
using System.Collections;

public class AverageEnemy : HumanBase {

    private int scoreIncrease;
    private int charCounter;

    // Use this for initialization
    public override void Start()
    {
        base.Start();

        for (int i = 0; i < StaticVars.addScore; i++)
        {
            charCounter = UnityEngine.Random.Range(0, 4);
            scoreIncrease = UnityEngine.Random.Range(-2, 2);
            characteristics[charCounter] += scoreIncrease;

            if (characteristics[scoreIncrease] > 10)
            {
                characteristics[i]--;
                StaticVars.addScore++;
            }

        }


    }

    public override sealed void Attack()
    {
        this.GetComponent<EnemyAttack>().Attack();

    }
}

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

        for (int i = 0; i < chngScore; i++)
        {
            charCounter = UnityEngine.Random.Range(0, 4);
            scoreIncrease = UnityEngine.Random.Range(-1, 1);
            characteristics[charCounter] += scoreIncrease;

            //if (characteristics[scoreIncrease] > 10)
            //{
            //    characteristics[i]--;
            //    chngScore++;
            //}

        }


    }

    public override sealed void Attack()
    {
        if (!tired)
        {
            tired = true;
            this.GetComponent<EnemyAttack>().Attack();
           
        }
        StartCoroutine(TiredCounter());

    }

    IEnumerator TiredCounter()
    {
        yield return new WaitForSeconds(2);
        tired = false;
    }
}

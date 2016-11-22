using UnityEngine;
using System.Collections;

public class AverageEnemy : HumanBase {

    

    // Use this for initialization
    public override void Start()
    {
        base.Start();

    }

    public override sealed void Attack()
    {
        this.GetComponent<EnemyAttack>().Attack();
    }
}

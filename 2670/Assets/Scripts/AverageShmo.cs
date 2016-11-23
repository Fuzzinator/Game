using UnityEngine;
using System.Collections;

public class AverageShmo : HumanBase {

    public override void Start()
    {
        base.Start();
        CountEnemies.friends.Add(gameObject);
    }


    public override sealed void Talk()
    {
        this.GetComponent<FriendTalk>().Speak();
    }
}

using UnityEngine;
using System.Collections;

public class AverageShmo : HumanBase {

    public string words;

    public override void Start()
    {
        base.Start();
        CountEnemies.friends.Add(gameObject);
        print(sayHello(words));
    }


    public override sealed void Talk()
    {
        this.GetComponent<FriendTalk>().Speak();
    }

    public static string sayHello(string s)
    {
        return "Hey friend! Over Here!";
    }
}

using UnityEngine;
using System.Collections;

public class AverageShmo : HumanBase {

    public override sealed void Talk()
    {
        this.GetComponent<FriendTalk>().Speak();
    }
}

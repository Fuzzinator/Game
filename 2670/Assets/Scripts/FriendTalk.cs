using UnityEngine;
using System.Collections;

public class FriendTalk : MonoBehaviour {

    public void Speak()
    {
        print("Hello friend!");

        switch (Player.intelligence)
        {
            case 5:
                print("You seem kinda average. You grab weapon over there.");
                break;
            case 6:
                print("Something tells me you're a tad smarter than most but youre gonna need that weapon over there.");
                break;
            case 7:
                print("You're pretty smart aren't you? Better grab that weapon square to defeat the foe!");
                break;
            case 8:
                print("You must be the smartest guy I've ever met! I'll bet you already know to grab that weapon square to defeat the foe!");
                break;
            case 9:
                print("Damn you're smart! The weapon over there is all yours");
                break;
            case 10:
                print("I can feel your brainwaives! You might not need that weapon over there.");
                break;


        }
    }
}

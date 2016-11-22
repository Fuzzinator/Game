using UnityEngine;
using System.Collections;

public class FriendTalk : MonoBehaviour {

    public void Speak()
    {
        print("Hello friend!");

        switch (Player.intelligence)
        {
            case 5:
                print("You seem kinda average");
                break;
            case 6:
                print("Something tells me you're a tad smarter than most");
                break;
            case 7:
                print("You're pretty smart aren't you");
                break;
            case 8:
                print("You must be the smartest guy I've ever met");
                break;
            case 9:
                print("Damn you're smart!");
                break;
            case 10:
                print("I can feel your brainwaives!");
                break;


        }
    }
}

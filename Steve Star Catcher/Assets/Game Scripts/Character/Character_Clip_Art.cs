using UnityEngine;
using System.Collections;



public class Character_Clip_Art : MonoBehaviour
{
    public Transform CharacterArt;

    public bool forward = true;

    void FlipCharacter (KeyCode  _keyCode)
    {

        switch (_keyCode)
        {
            case KeyCode.RightArrow:
                if (forward)
                {
                    CharacterArt.Rotate(0, 180, 0);
                    print("Right");
                    forward = false;
                   
                }
                break;

            case KeyCode.D:
                if (forward)
                {
                    CharacterArt.Rotate(0, 180, 0);
                    print("Right");
                    forward = false;

                }
                break;

            case KeyCode.LeftArrow:
                if (!forward)
                {
                    CharacterArt.Rotate(0, 180, 0);
                    print("Left");
                    forward = true;
                }
            break;

            case KeyCode.A:
                if (!forward)
                {
                    CharacterArt.Rotate(0, 180, 0);
                    print("Left");
                    forward = true;
                }
                break;

        }
        
        //forward = _b;
    }   

    void StopScipts()
    {


    }

    void Start ()
    {
        UserInputs.UserInput += FlipCharacter;

    }

    void OnDestroy()
    {
        UserInputs.UserInput -= FlipCharacter;

    }
}

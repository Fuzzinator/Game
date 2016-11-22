using UnityEngine;
using System.Collections;
using System;


public class Player : HumanBase {

    Action<int> Move;
    public static Action<KeyCode> UserInput;

    public CharacterController myCC;
    

    private Vector3 tempPos;
    public static float playerSpeed;
    public static new int strength;
    public static new int perception;
    public static new int intelligence;
    public static new int dexterity;
    public static new int charisma;

    private int scoreIncrease;

    // Use this for initialization
    public override void Start () {
        base.Start();



        for (int i = 0; i < StaticVars.addScore; i++)
        {
            scoreIncrease = UnityEngine.Random.Range(0, 4);
            characteristics[scoreIncrease]++;

            if (characteristics[scoreIncrease] > 10)
            {
                characteristics[i]--;
                StaticVars.addScore++;
            }

        }

        strength = characteristics[0];
        perception = characteristics[1];
        intelligence = characteristics[2];
        dexterity = characteristics[3];
        charisma = characteristics[4];


        playerSpeed = speed;
        playerSpeed += ((dexterity * 2) - playerSpeed);

        print("Your characters base stats are: Strength:" + strength + " Perception:" + perception
            + " Intelligence:" + intelligence + " Dexterity:" + dexterity + " Charisma:" + charisma);

        tempPos.x = StaticVars.playerSpeed * Input.GetAxis("Horizontal");


        //StartCoroutine(BaseState());

        // Move = MoveHander(dexterity);

    }

    //IEnumerator BaseState()
    //{
    //    //if (Input.GetKeyDown(KeyCode.RightArrow))// && UserInput != null)
    //    //{

    //    //    //UserInput(KeyCode.RightArrow);
    //    //}
    //    //if (Input.GetKeyDown(KeyCode.LeftArrow))// && UserInput != null)
    //    //{
    //    //    //UserInput(KeyCode.LeftArrow);
    //    //}
    //    if (Input.GetKeyDown(KeyCode.Space))// && UserInput != null)
    //    {
    //       // UserInput(KeyCode.Space);
    //    }

    //    if (Input.GetKeyDown(KeyCode.Escape))
    //    {
    //        if (Time.timeScale == 1)
    //        {
    //            //pauseScreen.SetActive(true);
    //            Time.timeScale = 0;
    //        }
    //        else
    //        {
    //            //pauseScreen.SetActive(false);
    //            Time.timeScale = 1;
    //        }

    //    }
    //   for(float i = 0; i < StaticVars.endTime;)
    //    {
    //        tempPos.x = speed * Input.GetAxis("Horizontal");
    //        tempPos.x = 

    //        StaticVars.idleTime += 1 * Time.deltaTime;

    //        i += 1 * Time.deltaTime;
    //        print(i);
    //    }

    //    yield return new WaitForSeconds(.01f);
    //}

    int MoveHander(int s)
    {
        print("Action");

        return s;

    }

    
	
}

using UnityEngine;
using System.Collections;
using System;


public class Player : HumanBase {

    Action<int> Move;
    public static Action<KeyCode> UserInput;

    public CharacterController myCC;
    

    private Vector3 tempPos;

    

    // Use this for initialization
    public override void Start () {
        base.Start();

        for (int i = 0; i < StaticVars.addScore; i++)
        {
            characteristics[UnityEngine.Random.Range(0, 3)]++;

        }

        strength = characteristics[0];
        perception = characteristics[1];
        intelligence = characteristics[2];
        dexterity = characteristics[3];

        StaticVars.playerSpeed = speed;
        StaticVars.playerSpeed += ((dexterity * 2) - StaticVars.playerSpeed);

        print("Your characters base stats are: " + strength + " " + perception + " " + intelligence + " " + dexterity);

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

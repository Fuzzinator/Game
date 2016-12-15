using UnityEngine;
using System.Collections;
using System;


public class Player : HumanBase {

    Action<int> Move;
    public static Action<KeyCode> UserInput;

    public CharacterController myCC;

    public GameObject foe;
    

    private Vector3 tempPos;
    public static float playerSpeed;
    public static new int strength;
    public static new int perception;
    public static new int intelligence;
    public static new int dexterity;
    public static new int charisma;
    //public int damage;
    public int hitCount;

    

    public int numAttacks;

    public static bool tired;

    private int scoreIncrease;


    // Use this for initialization
    public override void Start () {
        base.Start();


        tired = false;

        for (int i = 0; i < StaticVars.addScore; i++)
        {
            scoreIncrease = UnityEngine.Random.Range(0, 4);
            characteristics[scoreIncrease]++;

            if (characteristics[scoreIncrease] > 10)
            {
                characteristics[scoreIncrease]--;
                StaticVars.addScore++;
            }

        }

        hitCount = 0;

        strength = characteristics[0];
        perception = characteristics[1];
        intelligence = characteristics[2];
        dexterity = characteristics[3];
        charisma = characteristics[4];

        numAttacks = dexterity / 2;

        foreach (char letter in "Hello")
        {
            print(letter);
        }
        


        playerSpeed = speed;
        playerSpeed += ((dexterity * 2) - playerSpeed);

        print("Your characters base stats are: Strength:" + strength + " Perception:" + perception
            + " Intelligence:" + intelligence + " Dexterity:" + dexterity + " Charisma:" + charisma);

        tempPos.x = StaticVars.playerSpeed * Input.GetAxis("Horizontal");


    }

    public void Attack(GameObject hit)
    {
        
        
        

        if (!tired)
        {
            
            while (hitCount < numAttacks)
            {
                
                    print("You swing at the enemy!");
                    StartCoroutine(SmallPause());
                    Damage(hit, hitCount);
                    hitCount++;
                    StartCoroutine(SmallPause());
                
            }
            hitCount = 0;
            tired = true;
            hit.GetComponent<EnemyAttack>().Attack();

        }
        StartCoroutine(TiredCount());
    }

    IEnumerator TiredCount()
    {
        yield return new WaitForSeconds(2);
        tired = false;

    }

    public static void Damage(GameObject hit, int damageNum)
    {
        print("You hit the enemy for " + damage + " damage");
        
    }

    IEnumerator SmallPause()
    {
        yield return new WaitForSeconds(1);
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

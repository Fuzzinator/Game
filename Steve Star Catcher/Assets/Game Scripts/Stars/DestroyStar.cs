using UnityEngine;
using System.Collections;
using System;

public class DestroyStar : MonoBehaviour {



    public float endTime = 1;

    public GameObject hare;
    public GameObject starColor;

    public int playerScore;

    public float forceDuration = 1f;

    public int forceTime = 100;

    public float forceRange = 300;

    public GameObject trail;

    public int whiteIncrease = 1;
    public int redIncrease = 2;
    public int blueIncrease = 3;
    public int greenIncrease = 5;

    //public static bool canCollect;

    private bool inAir = true;

    private Rigidbody rigid;

    private float force;

    private Vector3 forceVector;
    private Vector3 torqueVector;

    //IEnumerator EndStar()
    //{

    //    yield return WaitForSeconds(endTime);

        
    //}


        void Start()
    {
        rigid = GetComponent<Rigidbody>();
        StartCoroutine(RunRandomForce());
        //canCollect = true;
    }

        IEnumerator RunRandomForce()
    {
        force = UnityEngine.Random.Range(-forceRange, forceRange);

        if (inAir == true)
        {
            while (forceTime > 0)
            {
                yield return new WaitForSeconds(forceDuration);
                forceVector.x = force;
                torqueVector.z -= force * forceDuration;
                rigid.AddForce(forceVector);
                rigid.AddTorque(torqueVector);
                forceTime--;
                inAir = false;
            }
        }

    }


   // Use this for initialization

   //void OnCollisionEnter()
   // {
   //     Destroy(gameObject);
   // }
    void OnCollisionEnter(Collision col) {
        if (col.gameObject.name == "Character" && MovePlayer.hurt != true)
        {
            //print("hit player");
            if (starColor.name == "White_Star")
            {
                ++StaticVars.playerScore;
                StaticVars.totalTime += whiteIncrease;
            }else if(starColor.name == "Red_Star")
            {
                StaticVars.playerScore += redIncrease;
                StaticVars.totalTime += redIncrease;
            }
            else if (starColor.name == "Blue_Star")
            {
                StaticVars.playerScore += blueIncrease;
                StaticVars.totalTime += blueIncrease;
            }
            else if (starColor.name == "Green_Star")
            {
                StaticVars.playerScore += greenIncrease;
                StaticVars.totalTime += greenIncrease;
            }
            //gameObject.SetActive(false);
            Destroy(gameObject/*, endTime*/);
   

        }
        else
        {
            force = UnityEngine.Random.Range(forceTime, forceRange);
            forceVector.y = force+force;
            rigid.AddForce(forceVector+forceVector);
            trail.SetActive(false);
            Destroy(gameObject, endTime);

        }
    }


    }

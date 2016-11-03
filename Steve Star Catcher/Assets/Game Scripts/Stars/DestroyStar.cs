using UnityEngine;
using System.Collections;
using System;

public class DestroyStar : MonoBehaviour {



    public float endTime = 1;

    public GameObject hare;

    public int playerScore;

    public float forceDuration = 1f;

    public int forceTime = 10;

    public float forceRange = 120;

    public GameObject trail;

    public int increaseTime = 2;

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
        if (col.gameObject.name == "Character")
        {
            //print("hit player");
            ++StaticVars.playerScore;
            StaticVars.totalTime += increaseTime;
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

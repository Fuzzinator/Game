using UnityEngine;
using System.Collections;
using System;

public class DestroyStar : MonoBehaviour {



    public float endTime = 1;

    public GameObject hare;
    public GameObject starColor;
    public GameObject star;

    public int playerScore;

    public float forceDuration = 1f;

    public int forceTime = 100;

    public float forceRange = 300;

    public GameObject trail;

    public int whiteIncrease = 1;
    public int redIncrease = 2;
    public int blueIncrease = 3;
    public int greenIncrease = 5;

    public GameObject collideSparks;

    //public static bool canCollect;

    private bool inAir = true;

    private Rigidbody rigid;

    private float force;

    private Vector3 forceVector;
    private Vector3 torqueVector;

    private ParticleSystem starCore;

    public static Action<GameObject> showScore;
    public static string color;

    public static GameObject starObject;


    //IEnumerator EndStar()
    //{

    //    yield return WaitForSeconds(endTime);


    //}


    void Start()
    {
        starObject = gameObject;
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

    IEnumerator CollideSparks()
    {
        collideSparks.SetActive(true);
        yield return new WaitForSeconds(.1f);
        collideSparks.SetActive(false);
    }

    IEnumerator StarFlash()
    {
        print("StarFlash");
        starCore = star.GetComponent<ParticleSystem>();
        int i = 0;
        if(i < 10)
        {
            print("Dostuff");
            starCore.Stop();
            yield return new WaitForSeconds(1f);
            starCore.Play();
            yield return new WaitForSeconds(1f);
            i++;
        }

    }

    void OnCollisionEnter(Collision col) {
        if (col.gameObject.name == "Character" && MovePlayer.hurt != true)
        {
            //print("hit player");
            if (starColor.name == "White_Star")
            {
                ++StaticVars.playerScore;
                DifficultyStaticVars.startTime += whiteIncrease;
                //StartCoroutine(plusMinus.StarIncrease("White_Star", gameObject ));
            }
            else if(starColor.name == "Red_Star")
            {
                StaticVars.playerScore += redIncrease;
                DifficultyStaticVars.startTime += redIncrease;
                //StartCoroutine(plusMinus.StarIncrease("Red_Star", gameObject));
            }
            else if (starColor.name == "Blue_Star")
            {
                StaticVars.playerScore += blueIncrease;
                DifficultyStaticVars.startTime += blueIncrease;
                //StartCoroutine(plusMinus.StarIncrease("Blue_Star", gameObject));
            }
            else if (starColor.name == "Green_Star")
            {
                StaticVars.playerScore += greenIncrease;
                DifficultyStaticVars.startTime += greenIncrease;
                //StartCoroutine(plusMinus.StarIncrease("Green_Star", gameObject));
            }

            //gameObject.SetActive(false);
            //StartCoroutine(starSound.PlayStarSound());
            starSound.staticStarSound.Play();
            color = starColor.name;
            //showScore(gameObject);
            Destroy(gameObject/*, endTime*/);
   

        }
        else
        {
            force = UnityEngine.Random.Range(forceTime, forceRange);
            forceVector.y = force+force;
            rigid.AddForce(forceVector+forceVector);
            trail.SetActive(false);
            StartCoroutine(CollideSparks());
            StartCoroutine(StarFlash());
            Destroy(gameObject, endTime);

        }
    }


    }

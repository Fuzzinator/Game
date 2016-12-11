using UnityEngine;
using System.Collections;

public class SpawnWolf : MonoBehaviour
{

    public GameObject wolf;
    public GameObject wolfArt;
    public Transform spawn1;
    public Transform spawn2;
    //public Transform wolfDest;
    //public Transform wolfSpawn;
    public float offset = 30;

    public AudioSource wolfMusic;
    public AudioSource inGameMusic;

    


    private int spawnYN;
    //private int spawnMax = 10;
    //private int spawnYes = 7;

    //Vector3 hareVector3;
    Vector3 wolfVector3;
    Vector3 wolfArtVector;

    
    //public static bool canSpawnWolf = true;
    private bool mustRotate;
    //public bool firstCall1;
    //public bool firstCall2;

    // Use this for initialization
    //IEnumerator StopWolfSpawn()
    //{
    //    canSpawnWolf = false;
    //    yield return new WaitForSeconds(10);
    //    canSpawnWolf = true;
    //}

        void Start()
    {
        mustRotate = false;
        StaticVars.firstCall1 = false;
        StaticVars.firstCall2 = true;
    }

 

    IEnumerator SpawnerWolf()
    {


        int i = Random.Range(1, 10);
        


        if (i <= 5)
        {
            if(StaticVars.firstCall2)
            {
                //mustRotate = true;
                StaticVars.firstCall2 = false;
                wolfArt.transform.Rotate(0, 180, 0);
                mustRotate = false;
                StaticVars.firstCall1 = true;

            }
            //if (mustRotate)
            //{
            //    wolfArt.transform.Rotate(0, 180, 0);
            //    mustRotate = false;
            //    firstCall1 = true;
            //}

            wolfVector3 = new Vector3((spawn2.position.x + (4*offset)), wolf.transform.position.y, wolf.transform.position.z);
            wolf.transform.position = wolfVector3;

            //wolfArtVector = new Vector3(wolfArt.transform.position.x, spawn2.position.y, wolfArt.transform.position.z);
            //wolfArt.transform.position = wolfArtVector;
            EnemyAgent.destination = spawn1;
            offset /= 2;
            inGameMusic.Stop();
            wolfMusic.Play();

            //wolfSpawn = spawn2;



        }
        else
        {
            if(StaticVars.firstCall1)
            {
                //mustRotate = true;
                StaticVars.firstCall1 = false;
                wolfArt.transform.Rotate(0, 180, 0);
                mustRotate = false;
                StaticVars.firstCall2 = true;
            }
            //if (mustRotate)
            //{
            //    wolfArt.transform.Rotate(0, 180, 0);
            //    mustRotate = false;
            //    firstCall2 = true;
            //}

            wolfVector3 = new Vector3((spawn1.position.x), wolf.transform.position.y, wolf.transform.position.z);
            wolf.transform.position = wolfVector3;
            EnemyAgent.destination = spawn2;

            inGameMusic.Stop();
            wolfMusic.Play();

            




        }

        yield return new WaitForSeconds(1);

        StartCoroutine(WolfMusic());

        //StartCoroutine(StopWolfSpawn());
    }

    IEnumerator WolfMusic()
    {
        yield return new WaitForSeconds(10);
        wolfMusic.Stop();

    }

    void OnTriggerEnter(Collider col)
    {
        
        if (col.name == "Character")
        {
            spawnYN = Random.Range(0, DifficultyStaticVars.wolfFrequency);
        
            if (spawnYN >= DifficultyStaticVars.wolfSpawnYes && DifficultyStaticVars.wolfCanSpawn)
            {
                DifficultyStaticVars.wolfCanSpawn = false;
                //wolfDest =;



                StartCoroutine(SpawnerWolf());
                //StartCoroutine(StopWolfSpawn());
               

                //print("Here comes the wolf");
            }
        }
    }
}
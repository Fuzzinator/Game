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


    private int spawnYN;
    private int spawnMax = 10;
    private int spawnYes = 7;

    //Vector3 hareVector3;
    Vector3 wolfVector3;
    Vector3 wolfArtVector;

    private bool canSpawnWolf = true;
    private bool mustRotate;
    private bool firstCall1;
    private bool firstCall2;

    // Use this for initialization
    //IEnumerator StopWolfSpawn()
    //{
    //    canSpawnWolf = false;
    //    yield return new WaitForSeconds(10);
    //    canSpawnWolf = true;
    //}

        void Start()
    {
        firstCall1 = false;
        firstCall2 = true;
    }


    IEnumerator SpawnerWolf()
    {
        int i = Random.Range(1, 10);
        


        if (i <= 5)
        {
            if(firstCall2)
            {
                mustRotate = true;
                firstCall2 = false;
            }
            
            wolfVector3 = new Vector3((spawn2.position.x + (4*offset)), wolf.transform.position.y, wolf.transform.position.z);
            wolf.transform.position = wolfVector3;

            wolfArtVector = new Vector3(wolfArt.transform.position.x, spawn2.position.y, wolfArt.transform.position.z);
            wolfArt.transform.position = wolfArtVector;
            EnemyAgent.destination = spawn1;
            offset /= 2;
            //wolfSpawn = spawn2;
            if (mustRotate)
            {
                wolfArt.transform.Rotate(0, 180, 0);
                mustRotate = false;
            }
            firstCall1 = true;

        }
        else
        {
            if(firstCall1)
            {
                mustRotate = true;
                firstCall1 = false;
            }

            wolfVector3 = new Vector3((spawn1.position.x), wolf.transform.position.y, wolf.transform.position.z);
            wolf.transform.position = wolfVector3;
            EnemyAgent.destination = spawn2;

            if(mustRotate)
            {
                wolfArt.transform.Rotate(0, 180, 0);
                mustRotate = false;
            }

        }

        yield return new WaitForSeconds(10);
        canSpawnWolf = true;


        //StartCoroutine(StopWolfSpawn());
    }

    void OnTriggerEnter(/*Collider col*/)
    {
        print("triggering");
        spawnYN = Random.Range(0, spawnMax);
        if (/*col.name == "Character"*/ /*spawnYN >= spawnYes &&*/ canSpawnWolf)
        {
            canSpawnWolf = false;
            //wolfDest =;


            StartCoroutine(SpawnerWolf());
            //StartCoroutine(StopWolfSpawn());
            //yield return new WaitForSeconds(3);

            print("Here comes the wolf");
        }
    }
}
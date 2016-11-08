using UnityEngine;
using System.Collections;

public class SpawnWolf : MonoBehaviour {

    public GameObject wolf;
    public GameObject Hare;
    public float offset = 5;

    //Vector3 hareVector3;
    Vector3 wolfVector3;

    private bool canSpawnWolf = true;

	// Use this for initialization
    IEnumerator StopWolfSpawn()
    {
        canSpawnWolf = false;
        yield return new WaitForSeconds(10);
        canSpawnWolf = true;
    }
	
   void OnTriggerEnter(Collider col)
    {
        if (col.name == "Character" && canSpawnWolf)
        {
            wolfVector3 = new Vector3((Hare.transform.position.x - offset), wolf.transform.position.y, wolf.transform.position.z);
            wolf.transform.position = wolfVector3;
            StartCoroutine(StopWolfSpawn());
            //yield return new WaitForSeconds(3);

            print("Here comes the wolf");
        }
    }

	// Update is called once per frame
	void Update () {
	
	}
}

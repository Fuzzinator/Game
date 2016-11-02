using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class StarController : MonoBehaviour
{

    public List<Transform> spawners;
    public List<Transform> stars;

    void SpawnHandler(Transform _t)
    {
        spawners.Add(_t);

    }

    void StarHandler(Transform _t)
    {
        stars.Add(_t);

    }

    // Use this for initialization
    void Start()
    {
        StarSpawner.SendSpawner += SpawnHandler;
        Star.SendStar += StarHandler;
        
        if(stars != null && spawners != null)
        {
            StartCoroutine(Spawn());
        }
    }

    private bool canSpawn = true;
    private int starNum;
    private int spawnNum;

    IEnumerator Spawn()
    {
        while (canSpawn)
        {
            yield return new WaitForSeconds(1);

            stars[starNum].position = spawners[spawnNum].position;
            stars[starNum].GetComponent<MeshRenderer>().enabled = true;

            if (starNum < stars.Count-1)
            {
                starNum++;
            }
            else
            {
                starNum = 0;
            }

            if (spawnNum < spawners.Count - 1)
            {
                spawnNum++;
            }
            else
            {
                spawnNum = 0;
            }
        }
    }
}
using UnityEngine;
using System.Collections;
public class CloneStar : MonoBehaviour {

    public Transform[] spawnPoints;
    public GameObject[] star;
    public Object stars;

    public int spawnRate = 1;

    public bool canSpawnStars = true;


    private int i = 0;
    private int j = 0;
   

    IEnumerator SpawnStars ()
    {
        while (canSpawnStars)
        {

            i = Random.Range(0, spawnPoints.Length);


            //stars[j].SetActive(true);
            //stars[j].transform.localPosition = spawnPoints[i].position;

            //if (j < stars.Length)
            //{

            //    j++;
            //}
            //else { j = 0; }

 

            Instantiate(stars, spawnPoints[i].position, Quaternion.identity);

            yield return new WaitForSeconds(spawnRate);

           // i++;
        }


      
    }


	// Use this for initialization
	void Start () {
        StartCoroutine(SpawnStars());
	}
	
}

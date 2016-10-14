using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Terrain_Populateor : MonoBehaviour {

    public List<Transform> LevelArt;

    void AddToList(Transform _t)
    {

    }

    void Start()
    {
        //AddToTerrainList.SendThis += AddToList;

    }

    void OnBecameVisiable()
    {

        int i = Random.Range(0, LevelArt.Count - 1);

        LevelArt[i].position = transform.position;
    }
}

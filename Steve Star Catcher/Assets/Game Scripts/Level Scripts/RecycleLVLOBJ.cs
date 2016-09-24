using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class RecycleLVLOBJ : MonoBehaviour {

    private Vector3 newLocation;

    System.Random rnd = new System.Random();

    public List<Recycler> recyclableList;

    private int nextTerrain;

    private int i;

    void Start()
    {
        recyclableList = new List<Recycler>();
        Recycler.RecycleAction += RecycleActionHandler;

    }

    private void RecycleActionHandler(Recycler _recycler)
    {
        recyclableList.Add(_recycler);
    }

    void OnTriggerEnter()
    {
        nextTerrain = rnd.Next(1, recyclableList.Count - 1);

        newLocation.x = StaticVars.nextSectionPos;

        recyclableList[nextTerrain].cube.position = newLocation;
       

        StaticVars.nextSectionPos += StaticVars.distance;
       
     
        if(recyclableList.Count > 0)
            recyclableList.RemoveAt(nextTerrain);


    }

    
}

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class BackgroundRecycler : MonoBehaviour {

    private Vector3 newBackPos;

    System.Random backRnd = new System.Random();

    public List<BackRecycler> recyclableBackground;

    private int nextBackground;

    private int i;

    void Start()
    {
        recyclableBackground = new List<BackRecycler>();
        BackRecycler.RecycleAction += RecycleActionHandler;


    }

    private void RecycleActionHandler(BackRecycler _backRecycler)
    {
        recyclableBackground.Add(_backRecycler);
    }

    void OnTriggerEnter()
    {
        nextBackground = backRnd.Next(1, recyclableBackground.Count - 1);

        newBackPos.x = StaticVars.nextBackgroundPos;
        //newBackPos.z = this.gameObject.transform.position.z;
        //newBackPos.y = this.gameObject.transform.position.y;

        recyclableBackground[nextBackground].cube.position = newBackPos;


        StaticVars.nextBackgroundPos += StaticVars.backDistance;


        if (recyclableBackground.Count > 0)
            recyclableBackground.RemoveAt(nextBackground);


    }


}

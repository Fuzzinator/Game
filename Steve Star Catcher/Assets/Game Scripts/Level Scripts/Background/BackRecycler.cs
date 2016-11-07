using UnityEngine;
using System.Collections;
using System;

public class BackRecycler : MonoBehaviour
{

    public static Action<BackRecycler> RecycleAction;

    public bool canBeRecycled;

    public Transform cube;

    // Use this for initialization
    void Start()
    {
        cube = this.GetComponent<Transform>();
        if (RecycleAction != null && canBeRecycled)
        {
            RecycleAction(this);

        }
    }



    void OnTriggerEnter()
    {
        print("background");
        canBeRecycled = true;
        Start();

    }
}

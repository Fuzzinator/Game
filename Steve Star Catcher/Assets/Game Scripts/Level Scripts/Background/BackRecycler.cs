using UnityEngine;
using System.Collections;
using System;

public class BackRecycler : MonoBehaviour
{

    public static Action<BackRecycler> RecycleAction;

    public bool canBeRecycled;

    public Transform background;

    // Use this for initialization
    void Start()
    {
        background = this.GetComponent<Transform>();
        if (RecycleAction != null && canBeRecycled)
        {
            RecycleAction(this);

        }
    }



    void OnTriggerEnter()
    {

        canBeRecycled = true;
        Start();

    }
}

using UnityEngine;
using System.Collections;

public class RecycleLVLOBJ : MonoBehaviour {

    private Vector3 newLocation;

    void OnTriggerEnter()
    {

        newLocation.x = StaticVars.nextSectionPos;

        transform.position = newLocation;

        StaticVars.nextSectionPos += StaticVars.distance;

    }
}

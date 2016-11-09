using UnityEngine;
using System.Collections;

public class WolfReset : MonoBehaviour {

    public Transform wolfAgent;
    public Transform wolfObj;
    public Transform resetSpot;

    private Vector3 reset;





    void OnTriggerEnter()
    {
        print("reset!");
        reset = new Vector3(resetSpot.position.x, resetSpot.position.y, resetSpot.position.z);
        wolfAgent.position = reset;
        wolfObj.position = reset;
        SpawnWolf.canSpawnWolf = true;
    }
	
}

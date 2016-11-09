using UnityEngine;
using System.Collections;

public class EnemyAgent : MonoBehaviour {

    public NavMeshAgent myAgent;
    public Transform startPos;
    public static Transform destination;

    void Start()
    {
        destination = startPos;
    }

	// Update is called once per frame
	void Update () {

        myAgent.destination = destination.position;

	}
}

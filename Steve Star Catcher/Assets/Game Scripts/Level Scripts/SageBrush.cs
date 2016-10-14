using UnityEngine;
using System.Collections;

public class SageBrush : MonoBehaviour {

    public float tempSpeed;

    public GameObject thePlayer;

	void OnTriggerEnter()
    {
        MovePlayer MovePlayer = thePlayer.GetComponent<MovePlayer>();
        tempSpeed = MovePlayer.speed;
        MovePlayer.speed = MovePlayer.speed / 2;

    }

    void OnTriggerExit()
    {
        GameObject thePlayer = GameObject.Find("Character");
        MovePlayer MovePlayer = thePlayer.GetComponent<MovePlayer>();
        MovePlayer.speed = tempSpeed;
    }
}

using UnityEngine;
using System.Collections;

public class UpdateScript : MonoBehaviour {


    public CharacterController creature;
    private float gravity = 9.81f ;
    private Vector3 tempPos;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        tempPos.y -= gravity * Time.deltaTime;
        creature.Move(tempPos);
	
	}
}

using UnityEngine;
using System.Collections;

public class MovePlayer : MonoBehaviour {

    //use to move player
    private CharacterController controller;


    //assign location as a temp var to move character
    private Vector3 tempposition;

    // The speed the character moves
    public float speed = 10f;
    //The speed the character falls
    public float gravity = 1f;
    //speed and distance character jumps up
    public float jumpForce = 20f ;


	// Use this for initialization
	void Start () {
        controller = GetComponent<CharacterController>();



	}
	
	// Update is called once per frame update is bad
	void Update () {

        //jump
        if (Input.GetKeyDown("space"))
        {
            tempposition.y = jumpForce;


        }


        //use axis as input w/ speed the character can hold or move left or right
        tempposition.x = speed*Input.GetAxis("Horizontal");


        //move method takes temp vector3 to move and then use deltatime to control the speed by seconds instead of frames
        controller.Move(tempposition * Time.deltaTime);




        //Set gravity
        tempposition.y -= gravity;

    }
}

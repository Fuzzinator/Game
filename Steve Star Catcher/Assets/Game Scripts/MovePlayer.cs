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
    public float jumpForce = 10f ;
    // sliding variables
    public int slideDuration = 100;
    public float slideTime = 0.01f;

    //Coroutine for sliding character
    IEnumerator Slide()
    {
        //set temp var to value of slideDuration
        int tempDuration = slideDuration;
        float tempSpeed = speed;
        //while loop as long as slideDuration is greater than 0
        while (slideDuration >0)
        {
            //decrement slideDuration
            slideDuration--;
            //yeild pauses the coroutine
            //return send to couroutine to do operation while yeilding
            //new creates new instance of object
            //WaitForSecond object that waits for duration of time
            yield return new WaitForSeconds(slideTime);
            speed += speed;
        }
        slideDuration = tempDuration;
        speed = tempSpeed;

    } 
    int jumpCount = 0;
    int jumpMax = 2;

    // Use this for initialization
    void Start () {
        controller = GetComponent<CharacterController>();

  

	}
	
	// Update is called once per frame update is bad
	void Update () {
        

        //jump
        if (Input.GetKeyDown("space") && jumpCount < jumpMax-1)
        {
            tempposition.y = jumpForce;
            jumpCount++;

        }
        if (controller.isGrounded)
        {
            jumpCount = 0; 

        }

        if(Input.GetKey(KeyCode.RightArrow) && Input.GetKeyDown(KeyCode.S))
        {
            //a function that calls coroutine. use coroutine in argument
            StartCoroutine(Slide());
          
        }

        //use axis as input w/ speed the character can hold or move left or right
        tempposition.x = speed*Input.GetAxis("Horizontal");


        //move method takes temp vector3 to move and then use deltatime to control the speed by seconds instead of frames
        controller.Move(tempposition * Time.deltaTime);







        //Set gravity
        tempposition.y -= gravity;

    }
}

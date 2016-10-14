using UnityEngine;
using System.Collections;
using System;

public class MovePlayer : MonoBehaviour {

    //use to move player
    private CharacterController controller;

    public GameObject MidAir_Up;
    public GameObject MidAir_Down;
    public GameObject Idle;
    public GameObject Running;
    public GameObject Blink;

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

    public float idleTime;

    Action Idle_Hare;

    void Idle_HareHandler()
    {
        Idle.SetActive(true);
        MidAir_Up.SetActive(false);
        MidAir_Down.SetActive(false);
        Running.SetActive(false);

    }

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
        Idle_Hare = Idle_HareHandler;

  

	}
	
	// Update is called once per frame update is bad
	void Update () {

       // Idle_Hare();

        
        //jump
        if (Input.GetKeyDown("space") && jumpCount < jumpMax-1)
        {
            tempposition.y = jumpForce;
            jumpCount++;
            

        }
        if (controller.isGrounded == false)
        {
            if (tempposition.y >= 1 )
            {
                Idle.SetActive(false);
                MidAir_Up.SetActive(true);
                MidAir_Down.SetActive(false);
                Running.SetActive(false);
            }
            else if (tempposition.y < 1)
            {
                Idle.SetActive(false);
                MidAir_Up.SetActive(false);
                MidAir_Down.SetActive(true);
                Running.SetActive(false);
            }



        }

        if (controller.isGrounded)
        {
            jumpCount = 0;
            Idle.SetActive(true);
            MidAir_Up.SetActive(false);
            MidAir_Down.SetActive(false);

        }

        if(Input.GetKey(KeyCode.RightArrow) && Input.GetKeyDown(KeyCode.S))
        {
            //a function that calls coroutine. use coroutine in argument
            StartCoroutine(Slide());
          
        }

        //use axis as input w/ speed the character can hold or move left or right
        tempposition.x = speed*Input.GetAxis("Horizontal");

        if (Input.GetAxis("Horizontal") > 0)
        {
            if (controller.isGrounded)
            {
                Idle.SetActive(false);
                MidAir_Up.SetActive(false);
                MidAir_Down.SetActive(false);
                Running.SetActive(true);
            }
        }

        if (Input.GetAxis("Horizontal") < 0)
        {
            if (controller.isGrounded)
            {
                Idle.SetActive(false);
                MidAir_Up.SetActive(false);
                MidAir_Down.SetActive(false);
                Running.SetActive(true);
            }
        }


        if (Input.GetAxis("Horizontal") == 0)
        {
            if (controller.isGrounded)
            {
                Idle.SetActive(true);
                MidAir_Up.SetActive(false);
                MidAir_Down.SetActive(false);
                Running.SetActive(false);
            }
        }


        //move method takes temp vector3 to move and then use deltatime to control the speed by seconds instead of frames
        controller.Move(tempposition * Time.deltaTime);







        //Set gravity
        tempposition.y -= gravity;

    }
}

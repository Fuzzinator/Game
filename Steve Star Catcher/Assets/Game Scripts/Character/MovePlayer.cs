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
    public GameObject HurtAir;
    public GameObject HurtIdle;
    public GameObject HurtRunning;
    public GameObject Blink;

    //assign location as a temp var to move character
    private Vector3 tempposition;

    private Vector2 touchOrigin = -Vector2.one;

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

    public static bool hurt = false;

    public float hurtTime = 0.3f;

    public float force = 2;

    Action Idle_Hare;
    Action Hurt_Hare;

    void Idle_HareHandler()
    {
            Idle.SetActive(true);
            MidAir_Up.SetActive(false);
            MidAir_Down.SetActive(false);
            Running.SetActive(false);
            HurtAir.SetActive(false);
            HurtIdle.SetActive(false);
            HurtRunning.SetActive(false);
            hurt = false;
    }

    //void Hurt_HareHandler()
    //{
    //    Idle.SetActive(false);
    //    MidAir_Up.SetActive(false);
    //    MidAir_Down.SetActive(false);
    //    Running.SetActive(false);
    //    Hurt.SetActive(true);

    //}


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
    void Start ()
    {
        controller = GetComponent<CharacterController>();
        Idle_Hare = Idle_HareHandler;
        hurt = false;
        
        


    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.layer == 15)
        {
            StaticVars.playerScore++;
            print(StaticVars.playerScore);
        }
        //if(col.gameObject.layer == 13)
        //{
        //    //Hurt_Hare = Hurt_HareHandler;
        //    hurt = true;
        //    print("you got hurt");
        //}

    }

    //void OnTriggerEnter(Collider col)
    //{
    //    if (col.gameObject.name == "Hurt_Hare")
    //    {
    //        hurt = true;
    //        print("you got hurt");
    //        StartCoroutine(hare_hurt());
    //    }
    //}

    IEnumerator hare_hurt()
    {
        if (Input.GetAxis("Horizontal") > 0)
        {
            print("launch left");
            //tempposition.x = force;
            //controller.Move(tempposition * Time.deltaTime);
            
        }

        if (Input.GetAxis("Horizontal") < 0)
        {
            print("launch right");
            //tempposition.x = -force;
            //controller.Move(tempposition * Time.deltaTime);
        }
        yield return new WaitForSeconds(hurtTime);
        hurt = false;
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
            Idle.SetActive(false);
            Running.SetActive(false);
            HurtIdle.SetActive(false);
            HurtRunning.SetActive(false);

            if (hurt == false)
            {
                HurtAir.SetActive(false);

                if (tempposition.y >= 1)
                {
                    MidAir_Up.SetActive(true);
                    MidAir_Down.SetActive(false);
                }
                else if (tempposition.y < 1)
                {
                    MidAir_Up.SetActive(false);
                    MidAir_Down.SetActive(true);
                }
            }
            if (hurt)
            {
                MidAir_Up.SetActive(false);
                MidAir_Down.SetActive(false);
                Idle.SetActive(false);
                Running.SetActive(false);
                HurtAir.SetActive(true);
                //yield return new WaitForSeconds(3);
                //hurt = false;

            }
            //if (tempposition.y >= 1)
            //{
            //    Idle.SetActive(false);
            //    MidAir_Up.SetActive(true);
            //    MidAir_Down.SetActive(false);
            //    Running.SetActive(false);
            //    Hurt.SetActive(false);

            //}
            //else if (tempposition.y < 1)
            //{
            //    Idle.SetActive(false);
            //    MidAir_Up.SetActive(false);
            //    MidAir_Down.SetActive(true);
            //    Running.SetActive(false);
            //    Hurt.SetActive(false);
            //}



        }

        if (controller.isGrounded)
        {
            jumpCount = 0;
            MidAir_Up.SetActive(false);
            MidAir_Down.SetActive(false);
            HurtAir.SetActive(false);


            if (hurt)
            {
                
                Idle.SetActive(false);
                Running.SetActive(false);
                HurtIdle.SetActive(true);
            }
            else
            {
                Idle.SetActive(true);
                MidAir_Up.SetActive(false);
                MidAir_Down.SetActive(false);
                HurtIdle.SetActive(false);

            }


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
            if (controller.isGrounded && hurt != true)
            {
                Idle.SetActive(false);
                MidAir_Up.SetActive(false);
                MidAir_Down.SetActive(false);
                Running.SetActive(true);
                HurtAir.SetActive(false);
                HurtIdle.SetActive(false);
                HurtRunning.SetActive(false);
            }
            else if (controller.isGrounded && hurt == true)
            {
                MidAir_Up.SetActive(false);
                MidAir_Down.SetActive(false);
                Idle.SetActive(false);
                Running.SetActive(false);
                HurtAir.SetActive(false);
                HurtIdle.SetActive(false);
                HurtRunning.SetActive(true);
            }
        }

        if (Input.GetAxis("Horizontal") < 0)
        {
            if (controller.isGrounded && hurt != true)
            {
                Idle.SetActive(false);
                MidAir_Up.SetActive(false);
                MidAir_Down.SetActive(false);
                Running.SetActive(true);
                HurtAir.SetActive(false);
                HurtIdle.SetActive(false);
                HurtRunning.SetActive(false);
            }
            else if (controller.isGrounded && hurt == true)
            {
                MidAir_Up.SetActive(false);
                MidAir_Down.SetActive(false);
                Idle.SetActive(false);
                Running.SetActive(false);
                HurtAir.SetActive(false);
                HurtIdle.SetActive(false);
                HurtRunning.SetActive(true);
            }
        }


        if (Input.GetAxis("Horizontal") == 0)
        {
            HurtRunning.SetActive(false);
            Running.SetActive(false);

            if (controller.isGrounded&& hurt!=true)
            {
                Idle.SetActive(true);
                MidAir_Up.SetActive(false);
                MidAir_Down.SetActive(false);
                
                HurtAir.SetActive(false);
                HurtIdle.SetActive(false);
                //HurtRunning.SetActive(false);
            }else if (controller.isGrounded && hurt == true)
            {
                MidAir_Up.SetActive(false);
                MidAir_Down.SetActive(false);
                Idle.SetActive(false);
                
                HurtAir.SetActive(false);
                HurtIdle.SetActive(true);
            }
        }

        if(Input.touchCount > 0)
        {
            Touch mytouch = Input.touches[0];
            if(mytouch.phase == TouchPhase.Began)
            {
                touchOrigin = mytouch.position;
            }
            else if(mytouch.phase == TouchPhase.Ended && touchOrigin.x >= 0)
            {
                Vector2 touchEnd = mytouch.position;
                float touchX = touchEnd.x - touchOrigin.x;
                touchOrigin.x = -1;
                 
            }
        }

        //move method takes temp vector3 to move and then use deltatime to control the speed by seconds instead of frames
        controller.Move(tempposition * Time.deltaTime);








        if (!controller.isGrounded )
        {
            //Set gravity
            tempposition.y -= gravity;
        }

    }
}

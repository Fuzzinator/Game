using UnityEngine;
using System.Collections;

public class RunJump : MonoBehaviour {


   


    //assign location as a temp var
    //private Vector3 tempposition;

    //
    public float speed = 10;
    public float jumpForce = 5;
    private Rigidbody rb;
    public float jump = 0;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    void OnCollisionEnter (Collision col)
    {
        if (col.gameObject.tag == "Ground")
        {
            jump = 0;
        }

        if (col.gameObject.tag == "Death")
        {
            Destroy(col.gameObject);

            Application.LoadLevel(Application.loadedLevel);

        }
    }


// Update is called once per frame update is bad
void FixedUpdate () {


        if (Input.GetKeyDown(KeyCode.Space) && jump <= 1)
        {
            rb.AddForce(0, jumpForce, 0, ForceMode.Impulse);
            jump++;       

        }

        



        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(speed *Time.deltaTime, 0, 0, ForceMode.Impulse);

        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-speed *Time.deltaTime, 0, 0, ForceMode.Impulse);
        }




        /*    //use axis as input w/ speed the character can hold or move left or right
            tempposition.x = speed*Input.GetAxis("Horizontal");

            //use deltatime to control the speed by seconds instead of frames
            tempposition *= Time.deltaTime;


            //move method takes temp vector3 to move
            controller.Move(tempposition);

            if (Input.GetKeyDown("space"))
            {
                tempposition.y = jumpForce;

               //tempposition.y = jumpForce;
                print("you jumped");
            }

            tempposition.y = gravity;
            */


    }
}

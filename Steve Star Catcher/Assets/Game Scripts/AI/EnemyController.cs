using UnityEngine;
using System.Collections;
using System;

public class EnemyController : MonoBehaviour
{

    public CharacterController myCC;
    public float gravity = 1;
    // public float sideForce = 0;
    public Vector3 tempPOS;

    public GameObject character;

    public float tempX;

    public float wolfX;

    public bool facingFwrd;
    public bool facingBkwrd;

    Action TurnWolf;

    void TurnWolfHandler()
    {
        tempX = character.transform.position.x;

        wolfX = this.transform.position.x;

    }

    // Use this for initialization
    void Start()
    {
        TurnWolf = TurnWolfHandler;

    }
       

    // Update is called once per frame
    void Update()
    {


        wolfX = this.transform.position.x;
        tempX = character.transform.position.x;

        if (TurnWolf != null)
        {

            /*if (tempX > wolfX && facingFwrd == false)
            {

                print("turn forward");
                //facingHare = true;
                //transform.Rotate(0, 180, 0);
            }

            if (tempX > wolfX && facingBkwrd == false)
            {

                print("turn Backward");
                //facingHare = true;
                //transform.Rotate(0, 180, 0);
            }

            if (tempX == wolfX)
            {
                print("sit");
                //transform.Rotate(0, 180, 0);
            }
            */
            //tempPOS = transform.position;
            if(Wolf_Jump.canJump)
            { 
                tempPOS.y -= gravity * Time.deltaTime;
                myCC.Move(tempPOS);
            }
                // tempPOS.z = character.transform.position.z;
                // if (this.transform.position.z != 
                //     character.transform.position.z)

                //     transform.position = new Vector3
                //         (this.transform.position.x, tempPOS.y, tempPOS.z);
                //transform.position = tempPOS;


            }
    }
}

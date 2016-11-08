using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Jump_Button : MonoBehaviour {

    //public GameObject mo;
    //public int jumpVelocity = 10;
    //I made that number up, you'll have to play around with jumpVelocity

    //CharacterController charController;

    void Start()
    {

        //charController = mo.GetComponent<CharacterController>();
    }

    public void jumpButton()
    {
        print("jump");
        Input.GetKeyDown("space");
        //if (charController.isGrounded)
        //{

        //charController.velocity.y += jumpVelocity;
        //}
    }
}

using UnityEngine;
using System.Collections;

public class UpdateScript : MonoBehaviour {


    public CharacterController creature;
    public CharacterController gravityEffects;

    public float rotationSpeed = 10;
    public int jumpCount = 0;
    public int jumpMax = 2;
    public int jumpForce = 2;
    private float yaw = 0.0f;
    private float pitch = 0.0f;
    private float gravity = 9.81f ;
    private Vector3 tempPos;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


        tempPos.x = Input.GetAxis("Horizontal");
        tempPos.z = Input.GetAxis("Vertical");
        if (Input.GetKeyDown("space") && jumpCount < jumpMax - 1)
        {
            tempPos.y = jumpForce;
            jumpCount++;


        }
        
        
        //tempPos.y -= gravity * Time.deltaTime;
        //yaw += rotationSpeed * Input.GetAxis("Mouse X");
        //pitch -= 0;// rotationSpeed * Input.GetAxis("Mouse Y");

        //transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);


        creature.Move(tempPos);
	
	}
}

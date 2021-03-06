﻿using UnityEngine;
using System.Collections;

public class UpdateScript : MonoBehaviour {


    public CharacterController creature;
    public CharacterController gravityEffects;
    public GameObject player;

    public NavMeshAgent enemyNavMesh;
    public Transform playerPos;

    public float speed = 20;
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


    IEnumerator ResetJump ()
    {
        yield return new WaitForSeconds(.5f);
        jumpCount = 0;
    }
	
	// Update is called once per frame
	void Update () {


        if (Input.GetKeyDown(KeyCode.Escape))
        {
            

        }

        transform.Rotate(0, Input.GetAxis("Horizontal") * rotationSpeed, 0);
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        float curSpeed = Player.playerSpeed * Input.GetAxis("Vertical");
        creature.SimpleMove(forward * curSpeed);

        if (Input.GetKeyDown("space") && jumpCount < jumpMax)
        {
            tempPos.y = jumpForce;
            jumpCount++;

            if (jumpCount >= jumpMax)
            {
                StartCoroutine(ResetJump());
            }

        }
        

        if (Input.GetKeyDown("tab"))
        {
            player.GetComponent<CountEnemies>().enemiesSize();
        }

       
        tempPos.y -= gravity * Time.deltaTime;
        yaw += rotationSpeed * Input.GetAxis("Mouse X");
        pitch -= 0;
        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);


        creature.Move(tempPos);

        enemyNavMesh.destination = playerPos.position;

    }
}

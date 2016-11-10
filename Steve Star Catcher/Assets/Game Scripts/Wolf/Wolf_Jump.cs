using UnityEngine;
using System.Collections;


public class Wolf_Jump : MonoBehaviour
{

    public CharacterController myCC;
    public Vector3 tempPOS;
    public static bool canJump;
    public float jumpForce;
    public Rigidbody rb;


    void Start()
    {
        canJump = true;
        jumpForce = 10;
    }

    IEnumerator wolfJump()
    {
        int i = 20;

        //rb.AddForce(0, jumpForce, 0);
        //yield return new WaitForSeconds(.5f);

        //rb.AddForce(0, -(jumpForce + jumpForce), 0);
        //jumpForce -= i;

        //yield return new WaitForSeconds(.1f);
        ////rb.AddForce(0, jumpForce, 0);
        //rb.useGravity = true;
        //yield return new WaitForSeconds(2);
        //rb.useGravity = false;

        while (i > 0)
        {
            
            tempPOS.y = jumpForce;
            myCC.Move(tempPOS*Time.deltaTime);
            yield return new WaitForSeconds(.001f);
            i--;
        }
        if (i == 0)
        {
            tempPOS.y -= jumpForce * Time.deltaTime;
            print(tempPOS);
            myCC.Move(tempPOS);
            print(myCC.transform.position);
            i--;
        }
        yield return new WaitForSeconds(1f);
        canJump = true;

    }

   
    void OnTriggerEnter(Collider col)
    {
        if (col.name == "Character" && canJump == true)
        {
            print("jump");
            canJump = false;
            StartCoroutine(wolfJump());
        }

    }
}


using UnityEngine;
using System.Collections;

public class ParalaxingBackground : MonoBehaviour
{

    public GameObject player;
    //private Vector3 offset;

    private GameObject whichBack;


    private float offset; //= .2f;

    void Start()
    {
        if(whichBack.name == "Far_Back")
        {
            offset = DifficultyStaticVars.farBackSpeed;
        }
        if (whichBack.name == "Med_Back")
        {
            offset = DifficultyStaticVars.medBackSpeed;
        }
        if (whichBack.name == "Cls_Back")
        {
            offset = DifficultyStaticVars.clsBackSpeed;
        }

    }


    

    // Update is called once per frame
    void LateUpdate()
    {

        


        transform.position = new Vector3
             ((this.gameObject.transform.position.x + Time.deltaTime / offset), this.gameObject.transform.position.y, this.gameObject.transform.position.z);
    }
}
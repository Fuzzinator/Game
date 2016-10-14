using UnityEngine;
using System.Collections;

public class ParalaxingBackground : MonoBehaviour
{

    public GameObject player;
    //private Vector3 offset;


    public float offset = .2f;




    

    // Update is called once per frame
    void LateUpdate()
    {




        transform.position = new Vector3
             ((this.gameObject.transform.position.x + Time.deltaTime / offset), this.gameObject.transform.position.y, this.gameObject.transform.position.z);
    }
}
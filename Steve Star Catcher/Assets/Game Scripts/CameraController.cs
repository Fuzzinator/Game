using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    public GameObject player;
    //private Vector3 offset;

    
       //public float offset = .5f;
    
    
    

	// Use this for initialization
	void Start () {


        // offset = player.transform.position;
        //print(DifficultyStaticVars.cameraSpeed);


    }

    // Update is called once per frame
    void LateUpdate () {

        StaticVars.totalTime += 1 * Time.deltaTime;

      
       transform.position = new Vector3
            ((this.gameObject.transform.position.x + Time.deltaTime/DifficultyStaticVars.cameraSpeed), this.gameObject.transform.position.y, this.gameObject.transform.position.z);

            
            //player.transform.position + offset;
	
	}
}

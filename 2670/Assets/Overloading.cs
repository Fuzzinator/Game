using UnityEngine;
using System.Collections;

public class Overloading : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Move(10);
	}
	
	void Move (int speed)
    {
        Vector3 vector = new Vector3(speed, 0, 0);
        transform.position = vector;
    }

    void Move (string speed)
    {
        Vector3 vector = Vector3.zero;
        switch (speed)
        {
            case "fast":
                vector = new Vector3(100, 0, 0);
                break;

            case "slow":
                vector = new Vector3(1, 0, 0);
                break;

        }
        transform.position = vector;
    }
}

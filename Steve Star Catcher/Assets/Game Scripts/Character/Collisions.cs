using UnityEngine;
using System.Collections;

public class Collisions : MonoBehaviour {

    public GameObject star;

	void onTriggerEnter(Collision col)
    {
        print("touch");
        if(col.gameObject == star)
        {
            print("The PLayer hit the star!!!!");
        }
    }

}

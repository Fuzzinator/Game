using UnityEngine;
using System.Collections;

public class IncreaseScore : MonoBehaviour {

    void OnCollisionEnter(Collision hit)
    {
        if(hit.transform.gameObject.layer == 15)
        {
            print("hit a star");
            //Destroy(hit.gameObject);
        }
    }

}

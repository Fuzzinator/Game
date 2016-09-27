using UnityEngine;
using System.Collections;

public class Wolf : Enemies {

    void start()
    {
        declareStuff();
    }


	void Update()
    {
        hurtPlayer();
    }
         
}

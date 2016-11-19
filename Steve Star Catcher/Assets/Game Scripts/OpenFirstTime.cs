using UnityEngine;
using System.Collections;

public class OpenFirstTime : MonoBehaviour {

    public GameObject gameIntro;

	// Use this for initialization
	void Start () {
        if(StaticVars.firstRun == true)
        {
            gameIntro.SetActive(true);
        }

        StaticVars.firstRun = false;

	}
	
}

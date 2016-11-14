using UnityEngine;
using System.Collections;

public class ScoreTracker : MonoBehaviour {

    public int currentScore;

    void Start ()
    {
        StaticVars.playerScore = 0;
    }

	
	// Update is called once per frame
	void Update () {


        print(StaticVars.totalTime);
	}
}

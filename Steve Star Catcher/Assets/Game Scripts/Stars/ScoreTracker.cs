using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ScoreTracker : MonoBehaviour {

    //public int currentScore;
    public int currentLvl;

    void Start ()
    {
        //StaticVars.playerScore = 0;
        currentLvl = SceneManager.GetActiveScene().buildIndex;
        if (currentLvl == 1)
        {
            StaticVars.totalScore = 0;
        }
    }

	
	//// Update is called once per frame
	//void Update () {


 //       print(StaticVars.totalTime);
	//}
}

using UnityEngine;
using System.Collections;

public class HighScoreSetter : MonoBehaviour {

    public GameObject scoreWas;
    public GameObject highScore;

	// Use this for initialization
	void Start () {

        StaticVars.totalScore += StaticVars.playerScore;

        StaticVars.highScore = PlayerPrefs.GetInt("highscore");

        if (StaticVars.highScore < StaticVars.totalScore)
        {
            PlayerPrefs.SetInt("highscore", StaticVars.totalScore);
            highScore.SetActive(true);
            scoreWas.SetActive(false);
        }
        else 
        {
            highScore.SetActive(false);
            scoreWas.SetActive(true);
        }
        //print(StaticVars.totalScore);



    }
	
}

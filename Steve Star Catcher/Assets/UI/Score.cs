using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Text score;
    public string newScore;

    private 

	// Use this for initialization
	void Start () {
        //score.text = "0";

        StaticVars.totalScore += StaticVars.playerScore;
        StaticVars.highScore = PlayerPrefs.GetInt("highscore");

        if (StaticVars.highScore < StaticVars.totalScore)
        {
            PlayerPrefs.SetInt("highscore", StaticVars.totalScore);
            
        }
        
        newScore = StaticVars.totalScore.ToString();
        score.text = newScore;
    }
	
	//// Update is called once per frame
	//void Update () {

 //       newScore = StaticVars.totalScore.ToString();
 //       score.text = newScore;
	//}




}

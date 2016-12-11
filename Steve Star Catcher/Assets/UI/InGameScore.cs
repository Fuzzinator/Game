using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InGameScore : MonoBehaviour {

    public Text score;
    public string newScore;

	// Use this for initialization
	void Start () {
        StaticVars.playerScore = 0;

        score.text = "0";
        newScore = StaticVars.playerScore.ToString();
    }
	
	// Update is called once per frame
	void Update () {

        newScore = StaticVars.playerScore.ToString();
        score.text = newScore;
	}
}

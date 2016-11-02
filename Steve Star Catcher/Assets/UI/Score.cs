using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Text score;
    public string newScore;

	// Use this for initialization
	void Start () {
        score.text = "5";
        newScore = StaticVars.playerScore.ToString();
    }
	
	// Update is called once per frame
	void Update () {

        newScore = StaticVars.playerScore.ToString();
        score.text = newScore;
	}
}

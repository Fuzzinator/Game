using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class displayHighScore : MonoBehaviour {

    public Text highScore;

	// Use this for initialization
	void Start () {

        highScore.text = PlayerPrefs.GetInt("highscore").ToString();
    }
	
    void Update()
    {
        highScore.text = PlayerPrefs.GetInt("highscore").ToString();
    }
}

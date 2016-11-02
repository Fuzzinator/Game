using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DeathWall : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        StaticVars.nextSectionPos = StaticVars.startPos;
        //StaticVars.playerScore = 0;

	}

    void OnTriggerEnter ()
    {
        SceneManager.LoadScene(2);
    }
}

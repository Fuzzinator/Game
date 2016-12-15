using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NextLvl : MonoBehaviour {

    int currentScene;

	// Use this for initialization
	void Start () {
        currentScene = SceneManager.GetActiveScene().buildIndex;
        if(currentScene == 1)
        {
            StaticVars.nextLvl = 4;
        }
        if (currentScene == 4)
        {
            StaticVars.nextLvl = 6;
        }
        else
        {
            StaticVars.nextLvl++;
        }
    }
	
}

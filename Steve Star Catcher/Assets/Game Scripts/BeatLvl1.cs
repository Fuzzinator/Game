using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BeatLvl1 : MonoBehaviour {

    private int currentLvl;

    void OnTriggerEnter()
    {
        currentLvl = SceneManager.GetActiveScene().buildIndex;


        StaticVars.playerScore += (int)((currentLvl/1.5)*10);

        
        SceneManager.LoadScene(3);
    }



}

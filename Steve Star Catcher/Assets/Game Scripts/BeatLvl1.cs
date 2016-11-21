using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BeatLvl1 : MonoBehaviour {


    void OnTriggerEnter()
    {
        StaticVars.playerScore += 50;
        SceneManager.LoadScene(3);
    }



}

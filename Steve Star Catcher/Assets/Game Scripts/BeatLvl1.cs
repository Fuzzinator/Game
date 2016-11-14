using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BeatLvl1 : MonoBehaviour {


    void OnTriggerEnter()
    {

        SceneManager.LoadScene(3);
    }



}

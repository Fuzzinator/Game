using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {


    public Text timer;

    private int seconds;
    private int minutes;
    private string time;
    private float secsToMin;
    public Light gameLight;
    private int doubleDigits = 10;




    //int totalSeconds = 222;
    //int seconds = totalSeconds % 60;
    //int minutes = totalSeconds / 60;
    //string time = minutes + ":" + seconds;


    // Use this for initialization
    void Start ()
    {
        secsToMin = 60;
        StaticVars.totalTime = 15;
        seconds = (int)(StaticVars.totalTime % secsToMin);
        minutes = (int)(StaticVars.totalTime / secsToMin);
        time = minutes + ":" + seconds;
    }

    void checkTime()
    {
        if (seconds >= doubleDigits)
        {
            time = minutes + ":" + seconds;
        }
        else
        {
            time = minutes + ":0" + seconds;

        }

    }
	
	// Update is called once per frame
	void Update ()
    {
        //gameLight.intensity
        if (StaticVars.totalTime > 0)
        {
            //StaticVars.totalTime -= Time.deltaTime;
        }
        else if(StaticVars.totalTime <= 0)
        {
            print("Time's Up!");
            SceneManager.LoadScene(2);
        }

        seconds = (int)(StaticVars.totalTime % secsToMin);
        minutes = (int)(StaticVars.totalTime / secsToMin);

        checkTime();
        //time = "" + (int)totalTime;

        timer.text = time;

	}
}

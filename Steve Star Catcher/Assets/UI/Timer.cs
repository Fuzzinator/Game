using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {

    public float startTime;
    
    public Text timer;

    private int seconds;
    private int minutes;
    private string time;
    private float secsToMin;
    public float totalTime;
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
        totalTime = 90;
        seconds = (int)(totalTime % secsToMin);
        minutes = (int)(totalTime / secsToMin);
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
        if (totalTime > 0)
        {
            totalTime -= Time.deltaTime;
        }
        else if( totalTime == 0)
        {
            SceneManager.LoadScene(2);
        }

        seconds = (int)(totalTime % secsToMin);
        minutes = (int)(totalTime / secsToMin);

        checkTime();
        //time = "" + (int)totalTime;

        timer.text = time;

	}
}

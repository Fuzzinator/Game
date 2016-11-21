﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StartGame : MonoBehaviour {


    public GameObject[] Game_Playables;
    public GameObject[] Turn_Off;

    public Button startButton;

    void Start()
    {
        if (StaticVars.intro)
        {
            //Time.timeScale = 0;
            Button btn = startButton.GetComponent<Button>();
            btn.onClick.AddListener(TaskOnClick);
        }
        if(!StaticVars.intro)
        {
            Time.timeScale = 1;
            Turn_Off[0].SetActive(false);
        }

    }

    void TaskOnClick()
    {

        Time.timeScale = 1;
        //Game_Playables[0].SetActive(true);
        //Game_Playables[1].SetActive(true);
        //Game_Playables[2].SetActive(true);
        //Game_Playables[3].SetActive(true);
        //Game_Playables[4].SetActive(true);
        //Game_Playables[5].SetActive(true);
        //Game_Playables[6].SetActive(true);
        //Game_Playables[7].SetActive(true);
        //Game_Playables[8].SetActive(true);
        //Game_Playables[9].SetActive(true);


        StaticVars.intro = false;
        Turn_Off[0].SetActive(false);
            //Turn_Off[1].SetActive(false);
            //Turn_Off[2].SetActive(false);


    }

}

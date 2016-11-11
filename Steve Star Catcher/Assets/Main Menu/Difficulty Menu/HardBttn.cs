﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HardBttn : MonoBehaviour {

    public Button button;

    void Start()
    {
        Button btn = button.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {

        DifficultyStaticVars.cameraSpeed = 0.3f;
        DifficultyStaticVars.farBackSpeed = -.15f;
        DifficultyStaticVars.medBackSpeed = -.20f;
        DifficultyStaticVars.clsBackSpeed = -.25f;
        DifficultyStaticVars.startTime = 15;
        DifficultyStaticVars.wolfDamage = StaticVars.playerScore;
        DifficultyStaticVars.cactusDamage = 5;
        DifficultyStaticVars.hurtTime = 3;
        DifficultyStaticVars.wolfFrequency = 10;
        DifficultyStaticVars.wolfSpawnYes = 7;
        //DifficultyStaticVars.wolfJump;
        DifficultyStaticVars.wolfCanSpawn = true;
        SceneManager.LoadScene(1);
    }
}

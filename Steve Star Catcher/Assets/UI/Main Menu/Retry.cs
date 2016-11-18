using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{

    public Button playButton;

    void Start()
    {
        Button btn = playButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        Time.timeScale = 1;
        if (DifficultyStaticVars.difficulty == "Practice")
        {
            DifficultyStaticVars.cameraSpeed = 1f;
            DifficultyStaticVars.farBackSpeed = .7f;
            DifficultyStaticVars.medBackSpeed = .8f;
            DifficultyStaticVars.clsBackSpeed = .9f;
            DifficultyStaticVars.startTime = 180;
            DifficultyStaticVars.wolfDamage = 0;
            DifficultyStaticVars.cactusDamage = 0;
            DifficultyStaticVars.hurtTime = .5f;
            DifficultyStaticVars.wolfFrequency = 1;
            DifficultyStaticVars.wolfSpawnYes = 1;
            //DifficultyStaticVars.wolfJump;
            DifficultyStaticVars.wolfCanSpawn = false;
        }
        if (DifficultyStaticVars.difficulty == "Easy")
        {
            DifficultyStaticVars.cameraSpeed = 0.5f;
            DifficultyStaticVars.farBackSpeed = .55f;
            DifficultyStaticVars.medBackSpeed = .60f;
            DifficultyStaticVars.clsBackSpeed = .65f;
            DifficultyStaticVars.startTime = 60;
            DifficultyStaticVars.wolfDamage = 0;
            DifficultyStaticVars.cactusDamage = 1;
            DifficultyStaticVars.hurtTime = .5f;
            DifficultyStaticVars.wolfFrequency = 1;
            DifficultyStaticVars.wolfSpawnYes = 1;
            //DifficultyStaticVars.wolfJump;
            DifficultyStaticVars.wolfCanSpawn = false;
        }
        if (DifficultyStaticVars.difficulty == "Medium")
        {
            DifficultyStaticVars.cameraSpeed = 0.4f;
            DifficultyStaticVars.farBackSpeed = .45f;
            DifficultyStaticVars.medBackSpeed = .50f;
            DifficultyStaticVars.clsBackSpeed = .55f;
            DifficultyStaticVars.startTime = 30;
            DifficultyStaticVars.wolfDamage = 7;
            DifficultyStaticVars.cactusDamage = 3;
            DifficultyStaticVars.hurtTime = 1;
            DifficultyStaticVars.wolfFrequency = 10;
            DifficultyStaticVars.wolfSpawnYes = 9;
            //DifficultyStaticVars.wolfJump;
            DifficultyStaticVars.wolfCanSpawn = true;
        }
        if (DifficultyStaticVars.difficulty == "Hard")
        {
            DifficultyStaticVars.cameraSpeed = 0.3f;
            DifficultyStaticVars.farBackSpeed = .35f;
            DifficultyStaticVars.medBackSpeed = .40f;
            DifficultyStaticVars.clsBackSpeed = .45f;
            DifficultyStaticVars.startTime = 15;
            DifficultyStaticVars.wolfDamage = StaticVars.playerScore;
            DifficultyStaticVars.cactusDamage = 5;
            DifficultyStaticVars.hurtTime = 3;
            DifficultyStaticVars.wolfFrequency = 10;
            DifficultyStaticVars.wolfSpawnYes = 7;
            //DifficultyStaticVars.wolfJump;
            DifficultyStaticVars.wolfCanSpawn = true;
        }

        SceneManager.LoadScene(1);
    }
}




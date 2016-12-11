using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HardBttn : MonoBehaviour {

    public Button button;

    void Start()
    {
        DifficultyStaticVars.buttonAction = "NewGame";
        Button btn = button.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    static public void TaskOnClick()
    {

        DifficultyStaticVars.cameraSpeed = 0.3f;
        DifficultyStaticVars.farBackSpeed = .35f;
        DifficultyStaticVars.medBackSpeed = .40f;
        DifficultyStaticVars.clsBackSpeed = .45f;
        DifficultyStaticVars.startTime = 20;
        DifficultyStaticVars.wolfDamage = 10;
        DifficultyStaticVars.cactusDamage = 3;
        DifficultyStaticVars.hurtTime = 3;
        DifficultyStaticVars.wolfFrequency = 10;
        DifficultyStaticVars.wolfSpawnYes = 7;
        //DifficultyStaticVars.wolfJump;
        DifficultyStaticVars.wolfCanSpawn = true;
        DifficultyStaticVars.difficulty = "Hard";
        if (DifficultyStaticVars.buttonAction == "NewGame")
        {
            SceneManager.LoadScene(5);
        }
        else if (DifficultyStaticVars.buttonAction == "Retry")
        {
            SceneManager.LoadScene(1);
        }
    }
}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EasyBttn : MonoBehaviour
{

    public Button button;

    void Start()
    {
        DifficultyStaticVars.buttonAction = "NewGame";
        Button btn = button.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    static public void TaskOnClick()
    {

        DifficultyStaticVars.cameraSpeed = 0.5f;
        DifficultyStaticVars.farBackSpeed = .55f;
        DifficultyStaticVars.medBackSpeed = .60f;
        DifficultyStaticVars.clsBackSpeed = .65f;
        DifficultyStaticVars.startTime = 60;
        DifficultyStaticVars.wolfDamage = 0;
        DifficultyStaticVars.cactusDamage = 0;
        DifficultyStaticVars.hurtTime = .5f;
        DifficultyStaticVars.wolfFrequency = 1;
        DifficultyStaticVars.wolfSpawnYes = 1;
        //DifficultyStaticVars.wolfJump;
        DifficultyStaticVars.wolfCanSpawn = false;
        DifficultyStaticVars.difficulty = "Easy";
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

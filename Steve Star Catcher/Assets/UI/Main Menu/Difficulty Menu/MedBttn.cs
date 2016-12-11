using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MedBttn : MonoBehaviour
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

        DifficultyStaticVars.cameraSpeed = 0.4f;
        DifficultyStaticVars.farBackSpeed = .45f;
        DifficultyStaticVars.medBackSpeed = .50f;
        DifficultyStaticVars.clsBackSpeed = .55f;
        DifficultyStaticVars.startTime = 30;
        DifficultyStaticVars.wolfDamage = 5;
        DifficultyStaticVars.cactusDamage = 1;
        DifficultyStaticVars.hurtTime = 1;
        DifficultyStaticVars.wolfFrequency = 10;
        DifficultyStaticVars.wolfSpawnYes = 9;
        //DifficultyStaticVars.wolfJump;
        DifficultyStaticVars.wolfCanSpawn = true;
        DifficultyStaticVars.difficulty = "Medium";
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

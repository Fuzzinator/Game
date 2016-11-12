using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EasyBttn : MonoBehaviour
{

    public Button button;

    void Start()
    {
        Button btn = button.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
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
        DifficultyStaticVars.difficulty = "Easy";
        SceneManager.LoadScene(1);
    }
}

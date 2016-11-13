using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PracticeBttn : MonoBehaviour
{

    public Button button;

    void Start()
    {
        Button btn = button.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {

        DifficultyStaticVars.cameraSpeed = 1f;
        DifficultyStaticVars.farBackSpeed = 1.05f;
        DifficultyStaticVars.medBackSpeed = 1.1f;
        DifficultyStaticVars.clsBackSpeed = 1.15f;
        DifficultyStaticVars.startTime = 180;
        DifficultyStaticVars.wolfDamage = 0;
        DifficultyStaticVars.cactusDamage = 0;
        DifficultyStaticVars.hurtTime = .5f;
        DifficultyStaticVars.wolfFrequency = 1;
        DifficultyStaticVars.wolfSpawnYes = 1;
        //DifficultyStaticVars.wolfJump;
        DifficultyStaticVars.wolfCanSpawn = false;
        DifficultyStaticVars.difficulty = "Practice";
        SceneManager.LoadScene(1);
    }
}

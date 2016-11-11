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
        SceneManager.LoadScene(1);
    }
}

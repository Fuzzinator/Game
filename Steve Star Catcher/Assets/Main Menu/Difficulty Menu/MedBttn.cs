using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MedBttn : MonoBehaviour
{

    public Button button;

    void Start()
    {
        Button btn = button.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {

        DifficultyStaticVars.cameraSpeed = 0.6f;
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
        SceneManager.LoadScene(1);
    }
}

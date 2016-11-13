using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu_Bttn : MonoBehaviour {

    public Button startButton;

    void Start()
    {

        Button btn = startButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        Time.timeScale = 0;
    }

    void TaskOnClick()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;

    }
}

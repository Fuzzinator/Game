using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Resume_Bttn : MonoBehaviour {

    public GameObject pauseMenu;

    public Button startButton;

    void Start()
    {
        Button btn = startButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {

        pauseMenu.SetActive(false);
        Time.timeScale = 1;

        
    }



}

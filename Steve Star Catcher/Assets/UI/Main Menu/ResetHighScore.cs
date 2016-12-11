using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ResetHighScore : MonoBehaviour {

    public Button button;

    void Start()
    {
        Button btn = button.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        PlayerPrefs.SetInt("highscore", 0);       
    }
}

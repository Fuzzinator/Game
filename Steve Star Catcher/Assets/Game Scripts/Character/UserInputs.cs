using UnityEngine;
using System.Collections;
using System;

public class UserInputs : MonoBehaviour
{
    public GameObject pauseScreen;
    public static Action<KeyCode> UserInput;

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.RightArrow) && UserInput != null)
        {
            UserInput(KeyCode.RightArrow);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && UserInput != null)
        {
            UserInput(KeyCode.LeftArrow);
        }
        if (Input.GetKeyDown(KeyCode.Space) && UserInput != null)
        {
            UserInput(KeyCode.Space);
        }
        if (Input.GetKeyDown(KeyCode.D) && UserInput != null)
        {
            UserInput(KeyCode.D);
        }
        if (Input.GetKeyDown(KeyCode.A) && UserInput != null)
        {
            UserInput(KeyCode.A);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Time.timeScale == 1)
            {
                pauseScreen.SetActive(true);
                Time.timeScale = 0;
            }
            else
            {
                pauseScreen.SetActive(false);
                Time.timeScale = 1;
            }

        }
    }
}

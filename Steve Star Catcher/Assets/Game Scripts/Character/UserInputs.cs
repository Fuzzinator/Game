using UnityEngine;
using System.Collections;
using System;

public class UserInputs : MonoBehaviour
{

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

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
            }
            else
            {
                Time.timeScale = 1;
            }

        }
    }
}

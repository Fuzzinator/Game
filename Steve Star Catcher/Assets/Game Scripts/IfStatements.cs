using UnityEngine;
using System.Collections;
using System;

public class IfStatements : MonoBehaviour
{

    public bool isDoorunlockedlocked;

    void Start()
    {
        if (isDoorunlockedlocked)
        {
            Enter();

        } else
        {
            Exit();


        }


    }

    private void Exit()
    {
        print("The way is shut. He is coming");
    }

    private void Enter()
    {

        print("Speak friend and enter");

    }

}
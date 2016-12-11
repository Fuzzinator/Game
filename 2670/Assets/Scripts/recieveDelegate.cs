using UnityEngine;
using System.Collections;
using System;

public class recieveDelegate : MonoBehaviour {

	// Use this for initialization
	void Start () {
        delegates.MyEvent += MyEventHandler;
        delegates.MyEvent2 += MySecondEventHandler;
        delegates.MyEvent3 += MyThirdEventHandler;
        delegates.MyEvent5 += MyEvent5Handler;
	}



    private string MyEvent5Handler()
    {
        return "Woo! Start Game!";
    }

    private void MyThirdEventHandler(string s)
    {
        print(s);
    }

    private void MyEventHandler()
    {
        print("Stuff");
    }

    private void MySecondEventHandler()
    {
        print("Second stuff");
    }




}

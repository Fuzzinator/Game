using UnityEngine;
using System.Collections;
using System;

public class delegates : MonoBehaviour {

    public delegate void MyDelegate();
    public static MyDelegate MyEvent;

    public static Action MyEvent2;

    public delegate void MyDelegate2(string s);
    public static MyDelegate2 MyEvent3;

    public static Action<string> MyEvent4;

    public delegate string MyDelegate5();
    public static MyDelegate5 MyEvent5;

    public static Func<string> MyEvent6;


	// Use this for initialization
	void Start () {
        MyEvent();
        MyEvent2();
        MyEvent3("Even More Stuff!!!");
        MyEvent5();
        print(MyEvent5());
        
	}
	
}

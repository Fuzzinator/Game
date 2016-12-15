using UnityEngine;
using System.Collections;
using System;

public class Coroutines : MonoBehaviour {


    //This script exists only because i dont kow how many coroutines i already used and its faster
    //for me to just write a whole bunch than to search through and find them


	// Use this for initialization
	void Start () {
        StartCoroutine(Coroutine1());
	}

    private IEnumerator Coroutine1()
    {
        print("Coroutine1");
        yield return new WaitForSeconds(.1f);
        StartCoroutine(Coroutine2());

    }

    private IEnumerator Coroutine2()
    {
        print("Coroutine2");
        yield return new WaitForSeconds(.1f);
        StartCoroutine(Coroutine3());
    }

    private IEnumerator Coroutine3()
    {
        print("Coroutine3");
        yield return new WaitForSeconds(.1f);
        StartCoroutine(Coroutine4());
    }

    private IEnumerator Coroutine4()
    {
        print("Coroutine1");
        yield return new WaitForSeconds(.1f);
        print("No more coroutines in this script.");
        print("Man i'm lazy...");
        yield return new WaitForSeconds(2);
        print("seriously though i didnt put hardly any effort into this game...");
        yield return new WaitForSeconds(5);
        print("I totally understand pretty much everything you asked us to do though and i think, despite having been really lazy, i did it.");
    }
}

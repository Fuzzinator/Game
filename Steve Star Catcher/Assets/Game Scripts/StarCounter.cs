using UnityEngine;
using System.Collections;
using System;

public class StarCounter : MonoBehaviour
{
    Action StarFunctions;



    int red;
    int blue;
    int green;
    int white;
    float fallRate;
    int strInSky;
    int strInBag;
    int redPoint;
    int bluePoint;
    int greenPoint;
    int whitePoint;
    double redPercent;
    double bluePercent;
    double greenPercenet;
    double whitePercent;

    System.Random rnd = new System.Random();
    

    void StarFunctionsHandler()
    {

        print(strInSky);
        strInSky = strInSky - (int)(fallRate);
        if (strInSky <= 0)
        {
            StarFunctions = null;
        }

    }
    
    // Use this for initialization
    void Start()
    {

        red = 0;
        blue = 1;
        green = 2;
        white = 3;
        fallRate = rnd.Next(1, 10);
        strInSky = 100;
        strInBag = 0;
        redPoint = 10;
        bluePoint = 5;
        greenPoint = 20;
        whitePoint = 1;
        redPercent = 0.20;
        bluePercent = 0.25;
        greenPercenet = 0.10;
        whitePercent = 0.45;

        StarFunctions = StarFunctions;
    }

    // Update is called once per frame
    void Update()
    {


        if (StarFunctions != null)
        {
            StarFunctions();
        }

    }

    public int[] StarTypes()
    {

        int[] starPercents = new int [4];
        starPercents[red] = (int)(strInSky * redPercent);
        starPercents[blue] = (int)(strInSky * bluePercent);
        starPercents[green] = (int)(strInSky * greenPercenet);
        starPercents[white] = (int)(strInSky * whitePercent);

        return starPercents;
    }
}


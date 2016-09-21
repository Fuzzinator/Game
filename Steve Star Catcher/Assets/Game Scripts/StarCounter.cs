using UnityEngine;
using System.Collections;
using System;

public class StarCounter : MonoBehaviour
{
    Action StarFunctions;
    Action StarsLeft;

    int starTypes;
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
        
        if (strInSky <= 0)
        {
            StarFunctions = null;
        }

    }

    void StarsLeftHandler()
    {
        do
        {
            print(" There are " + strInSky + "stars left in the sky");
            strInSky = strInSky - (int)(fallRate);

        } while (strInSky > 0);

        

    }
    
    // Use this for initialization
    void Start()
    {
        starTypes = 3;
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

        StarFunctions = StarFunctionsHandler;
    }

    // Update is called once per frame
    void Update()
    {
        

        if (StarFunctions != null)
        {
            StarTypes();
        }

    }

    public int[] StarTypes()
    {

        int[] starPercents = new int [starTypes];
        starPercents[red] = (int)(strInSky * redPercent);
        starPercents[blue] = (int)(strInSky * bluePercent);
        starPercents[green] = (int)(strInSky * greenPercenet);
        starPercents[white] = (int)(strInSky * whitePercent);

        foreach (int stars in starPercents)
            print(stars);


        StarsLeft = StarsLeftHandler;

        return starPercents;
    }
}


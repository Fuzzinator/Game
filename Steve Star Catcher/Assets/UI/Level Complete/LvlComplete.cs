using UnityEngine;
using System.Collections;

public class LvlComplete : MonoBehaviour {

    //public int lvlBonus = 50;

    public float easy = 45;
    public float medium = 20;
    public float hard = 15;

	// Use this for initialization
	void Start () {

        //StaticVars.playerScore += lvlBonus;
        StaticVars.totalScore = StaticVars.playerScore;

        if (DifficultyStaticVars.difficulty =="Easy")
        {
            DifficultyStaticVars.startTime += easy;
        }

        if (DifficultyStaticVars.difficulty == "Medium")
        {
            DifficultyStaticVars.startTime += medium;
        }

        if (DifficultyStaticVars.difficulty == "Hard")
        {
            DifficultyStaticVars.startTime += hard;
        }

    }
	
}

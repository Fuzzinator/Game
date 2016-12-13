using UnityEngine;
using System.Collections;

public class plusMinus : MonoBehaviour {

    public GameObject minus1;
    public GameObject minus3;
    public GameObject minus5;
    public GameObject minus10;

    public GameObject plus1;
    public GameObject plus2;
    public GameObject plus3;
    public GameObject plus5;

    private static GameObject min1;
    private static GameObject min3;
    private static GameObject min5;
    private static GameObject min10;

    private static GameObject p1;
    private static GameObject p2;
    private static GameObject p3;
    private static GameObject p5;

    private static string difficulty;

    void Start()
    {
        difficulty = DifficultyStaticVars.difficulty;
        DestroyStar.showScore += showScoreHandler;

        min1 = minus1;
        min3 = minus3;
        min5 = minus5;
        min10 = minus10;
        p1 = plus1;
        p2 = plus2;
        p3 = plus3;
        p5 = plus5;
        
    }

    private void showScoreHandler(GameObject star)
    {
        
        StartCoroutine(StarIncrease(star));
    }

    public static IEnumerator cactusFlashMinus()
    {
        min1.SetActive(false);
        min3.SetActive(false);
        min5.SetActive(false);
        min10.SetActive(false);
        p1.SetActive(false);
        p2.SetActive(false);
        p3.SetActive(false);
        p5.SetActive(false);
        switch (difficulty)
        {
            case "Medium":
                min1.SetActive(true);
                break;
            case "Hard":
                min3.SetActive(true);
                break;
        }
        yield return new WaitForSeconds(.5f);
        min1.SetActive(false);
        min3.SetActive(false);
        min5.SetActive(false);
        min10.SetActive(false);
    }

    public static IEnumerator wolfFlashMinus()
    {
        switch (difficulty)
        {
            case "Medium":
                min5.SetActive(true);
                break;
            case "Hard":
                min10.SetActive(true);
                break;
        }
        yield return new WaitForSeconds(.5f);
        min1.SetActive(false);
        min3.SetActive(false);
        min5.SetActive(false);
        min10.SetActive(false);
    }


    public static IEnumerator StarIncrease(GameObject toDestroy)
    {
        min1.SetActive(false);
        min3.SetActive(false);
        min5.SetActive(false);
        min10.SetActive(false);
        p1.SetActive(false);
        p2.SetActive(false);
        p3.SetActive(false);
        p5.SetActive(false);
        switch (DestroyStar.color)
        {
            case "White_Star":
                p1.SetActive(true);
                break;
            case "Red_Star":
                p2.SetActive(true);
                break;
            case "Blue_Star":
                p3.SetActive(true);
                break;
            case "Green_Star":
                p5.SetActive(true);
                break;
        }
        
        Destroy(toDestroy);
        yield return new WaitForSeconds(.5f);
        p1.SetActive(false);
        p2.SetActive(false);
        p3.SetActive(false);
        p5.SetActive(false);
        //Destroy(star);
    }
    //void OnTriggerEnter(Collider col)
    //{

    //    if (col.name == "Damage")
    //    {
    //        minus1.SetActive(false);
    //        minus3.SetActive(false);
    //        minus5.SetActive(false);
    //        minus10.SetActive(false);
    //        StartCoroutine(cactusFlashMinus());
    //    }
    //    if (col.name == "Hurt_Hare")
    //    {
    //        minus1.SetActive(false);
    //        minus3.SetActive(false);
    //        minus5.SetActive(false);
    //        minus10.SetActive(false);
    //        StartCoroutine(wolfFlashMinus());
    //    }


    //}
}

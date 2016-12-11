using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HurtPlayer : MonoBehaviour {

    public GameObject hare;
    public GameObject damageCol;
    CharacterController cc;
    public float speed = -80;
    private Vector3 kickBack;

    public AudioSource whoops;


    public GameObject damageImage;


    //public int cactusDamage = 5;    

    IEnumerator FrontBlowBack()
    {
        
        int temp = 50;
        damageCol.SetActive(false);
        MovePlayer.hurt = true;

        StartCoroutine(FlashScreen());
        //DestroyStar.canCollect = false;
       
        if (temp > 0)
        {
            
            kickBack = new Vector3(speed, -speed, 0);
            cc = hare.GetComponent<CharacterController>();
            cc.Move(kickBack * Time.deltaTime);
            yield return new WaitForSeconds(01f);
            temp--;

        }
        
        yield return new WaitForSeconds(DifficultyStaticVars.hurtTime);
        MovePlayer.canFlash = true;
        MovePlayer.hurt = false;
        damageCol.SetActive(true);
        MovePlayer.hurt = false;
        //DestroyStar.canCollect = true;
    }

    IEnumerator FlashScreen()
    {
        damageImage.SetActive(true);
        yield return new WaitForSeconds(.2f);
        damageImage.SetActive(false);
        //yield return new WaitForSeconds(DifficultyStaticVars.hurtTime);
        //damageImage.color = Color.clear; //Color.Lerp(damageImage.color , Color.clear,)
    }

    void OnTriggerEnter(Collider col)
    {

        if (col.name == "KnockBackFront")
        {

            whoops.Play();
            MovePlayer.canFlash = false;

            if (StaticVars.playerScore >= DifficultyStaticVars.cactusDamage && MovePlayer.hurt == false)
            {
                //print("lose 5 stars");
                StaticVars.playerScore -= (int)DifficultyStaticVars.cactusDamage;
                print(StaticVars.playerScore);
            }
            if (StaticVars.playerScore < DifficultyStaticVars.cactusDamage && MovePlayer.hurt == false)
            {
                StaticVars.playerScore = 0;
                print("lose " + StaticVars.playerScore + "stars");
            }

            StartCoroutine(FrontBlowBack());

        }
        

    }
	
}

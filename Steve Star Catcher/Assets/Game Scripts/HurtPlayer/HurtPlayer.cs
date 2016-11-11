using UnityEngine;
using System.Collections;

public class HurtPlayer : MonoBehaviour {

    public GameObject hare;
    public GameObject damageCol;
    CharacterController cc;
    public float speed = -80;
    private Vector3 kickBack;

    //public int cactusDamage = 5;    

    IEnumerator FrontBlowBack()
    {
        
        int temp = 50;
        damageCol.SetActive(false);
        MovePlayer.hurt = true;
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
        damageCol.SetActive(true);
        MovePlayer.hurt = false;
        //DestroyStar.canCollect = true;
    }



	void OnTriggerEnter(Collider col)
    {

        if (col.name == "KnockBackFront")
        {

            print(StaticVars.playerScore);
            if (StaticVars.playerScore >= DifficultyStaticVars.cactusDamage && MovePlayer.hurt == false)
            {
                //print("lose 5 stars");
                StaticVars.playerScore -= (int)DifficultyStaticVars.cactusDamage; //TODO ADD IN POINT REDUCTION\
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

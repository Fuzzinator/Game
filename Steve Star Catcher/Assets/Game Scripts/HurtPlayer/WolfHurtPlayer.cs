using UnityEngine;
using System.Collections;

public class WolfHurtPlayer : MonoBehaviour {

    public GameObject hare;
    public GameObject damageCol;
    CharacterController cc;
    public float speed = -80;
    private Vector3 kickBack;

    public AudioSource whoops;

    //public int wolfDamage = 5;    

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
            whoops.Play();
            StaticVars.playerScore -= DifficultyStaticVars.wolfDamage;

            //print(StaticVars.playerScore);
            //if (StaticVars.playerScore >= wolfDamage && MovePlayer.hurt == false)
            //{
            //    //print("lose 5 stars");
            //    StaticVars.playerScore -= wolfDamage; //TODO ADD IN POINT REDUCTION\
            //    print(StaticVars.playerScore);
            //}
            //if (StaticVars.playerScore < wolfDamage && MovePlayer.hurt == false)
            //{
            //    StaticVars.playerScore = 0;
            //    print("lose " + StaticVars.playerScore + "stars");
            //}

            StartCoroutine(FrontBlowBack());

        }

    }
	
}

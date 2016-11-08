using UnityEngine;
using System.Collections;

public class HurtPlayer : MonoBehaviour {

    public GameObject hare;
    public GameObject damageCol;
    CharacterController cc;
    public float speed = -80;
    private Vector3 kickBack;
    

    IEnumerator FrontBlowBack()
    {
        
        int temp = 50;
        damageCol.SetActive(false);
        MovePlayer.hurt = true;
        //DestroyStar.canCollect = false;
        print("Hurt Player");
        if (temp > 0)
        {
            
            kickBack = new Vector3(speed, -speed, 0);
            cc = hare.GetComponent<CharacterController>();
            cc.Move(kickBack * Time.deltaTime);
            yield return new WaitForSeconds(01f);
            temp--;

        }
        
        yield return new WaitForSeconds(3);
        damageCol.SetActive(true);
        MovePlayer.hurt = false;
        //DestroyStar.canCollect = true;
    }

	void OnTriggerEnter(Collider col)
    {

        if(col.name == "KnockBackFront")
        {
            StartCoroutine(FrontBlowBack());
        }

    }
	
	// Update is called once per frame
	void Update () {
	
	}
}

using UnityEngine;
using System.Collections;

public class IEnum : MonoBehaviour {

    string[] screenTitles = { "3", "2", "1" };


	IEnumerator GameCountdown()
    {
        int i = 0;
        while (i < screenTitles.Length)
        {
            print(screenTitles[i]);
            yield return new WaitForSeconds(0.5f);
            i++;
        }
      
    }
    void start()
    {
        StartCoroutine(GameCountdown());

    }
	

}

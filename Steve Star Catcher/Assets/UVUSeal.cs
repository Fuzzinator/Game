using UnityEngine;
using System.Collections;

public class UVUSeal : MonoBehaviour {

    public GameObject uvusplashscreen;
    public GameObject video;

	// Use this for initialization
	void Start () {
        if (StaticVars.uvuSplash)
        {
            StartCoroutine(Uvu());
        }
        if (!StaticVars.uvuSplash)
        {
            video.SetActive(true);
            uvusplashscreen.SetActive(false);
        }

	}
	
    IEnumerator Uvu()
    {
        
        yield return new WaitForSeconds(3);
        StaticVars.uvuSplash = false;
        video.SetActive(true);
        uvusplashscreen.SetActive(false);
    }
}

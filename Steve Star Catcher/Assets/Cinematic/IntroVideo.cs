using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class IntroVideo : MonoBehaviour
{
    public GameObject fade;
    public GameObject canvas;
    public float duration = 13;
    //public AudioSource Music;

    private IEnumerator Fading()
    {
       // yield return new WaitForSeconds(3);
        //Music.Play();
        yield return new WaitForSeconds(duration);
        //fade.SetActive(true);
        //yield return new WaitForSeconds(.7f);
        StaticVars.uvuSplash = false;
        canvas.SetActive(true);
        fade.SetActive(false);
        //SceneManager.LoadScene(1);
    }

    // Use this for initialization
    void Start()
    {
        if (StaticVars.uvuSplash)
        {
            StartCoroutine(Fading());
        }
        if (!StaticVars.uvuSplash)
        {
            //Music.Play();
            canvas.SetActive(true);
            fade.SetActive(false);
        }
        
    }
}

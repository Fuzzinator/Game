using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Fade : MonoBehaviour {
    public GameObject fade;
    public GameObject canvas;

    private IEnumerator Fading()
    {
        yield return new WaitForSeconds(10);
        //fade.SetActive(true);
        //yield return new WaitForSeconds(.7f);
        canvas.SetActive(true);
        fade.SetActive(false);
        //SceneManager.LoadScene(1);
    }

	// Use this for initialization
	void Start () {
        StartCoroutine(Fading());
	}
}

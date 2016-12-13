using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;



public class Fade : MonoBehaviour {
    //public GameObject fade;
    public float duration = 5f;
    //public GameObject canvas;

    public IEnumerator Fading()
    {
        yield return new WaitForSeconds(duration);
       // fade.SetActive(true);
       // yield return new WaitForSeconds(.6f);
        //canvas.SetActive(true);
        //fade.SetActive(false);
        SceneManager.LoadScene(1);
    }

	// Use this for initialization
	void Start () {
        StartCoroutine(Fading());
	}

    void OnMouseDown()
    {
        SceneManager.LoadScene(1);
    }
}

using UnityEngine;
using System.Collections;

public class ClickContinue : MonoBehaviour {

    public GameObject video;
    public GameObject canvas;

    void OnMouseDown()
    {
        print("click");

        canvas.SetActive(true);
        video.SetActive(false);
    }
}

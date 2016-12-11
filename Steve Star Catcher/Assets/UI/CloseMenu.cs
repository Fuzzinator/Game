using UnityEngine;
using System.Collections;

public class CloseMenu : MonoBehaviour {

    public GameObject menuWindow;


    // Update is called once per frame
    void Update () {

        if (Input.GetKeyDown(KeyCode.Escape))
        {


            menuWindow.SetActive(false);


        }
    }
}

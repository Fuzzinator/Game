using UnityEngine;
using System.Collections;

public class resetMenu : MonoBehaviour
{

    public GameObject menuWindow;

    public GameObject continueBttn;
    public GameObject backBttn;
    public GameObject exitBttn;
    public GameObject text1;
    public GameObject text2;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            backBttn.SetActive(false);
            exitBttn.SetActive(false);
            continueBttn.SetActive(true);
            text1.SetActive(true);
            text2.SetActive(false);

            menuWindow.SetActive(false);


        }
    }
}

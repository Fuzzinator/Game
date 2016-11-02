using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ExitButton : MonoBehaviour
{
    public Button exitButton;

    void Start()
    {
        Button btn = exitButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        Application.Quit();
        print("close");

    }


    /*
        public float showSplashTimeout = 2.0F;
        private bool allowQuitting = false;
        //void Awake()
        //{
         //   DontDestroyOnLoad(.gameObject);
        //}
        void OnApplicationQuit()
        {
          //  if (Application.loadedLevelName.ToLower() != "finalsplash")
                StartCoroutine("DelayedQuit");

           // if (!allowQuitting)
                Application.CancelQuit();

        }
        IEnumerator DelayedQuit()
        {
            SceneManager.LoadScene(0);
            yield return new WaitForSeconds(showSplashTimeout);
            allowQuitting = true;
            Application.Quit();
        }
    */
}
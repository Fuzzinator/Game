using UnityEngine;
using System.Collections;

public class IfAndSwitch: MonoBehaviour {

    public float time;
    public int sleepHours;
    private int youGetSleep;


	// Use this for initialization
	void Start () {
        time = 12;
        sleepHours = 3;

	}
	
	// Update is called once per frame
	void Update () {



        if (sleepHours <= time)

        {
            youGetSleep = Random.Range(1, 5);
            switch (youGetSleep)
            {
                case 1:
                    print("You get to sleep");
                    break;
                case 2:
                    print("Congratulations! Sleep is your lady tonight!");
                    break;
                case 3:
                    print("Luck be sleeping tonight!");
                    break;
                case 4:
                    print("Boy you best go take a nap");
                    break;
                case 5:
                    print("AWWW YEAAAH SLEEP TIME!");
                    break;

            }


        }
             
	
	}
}

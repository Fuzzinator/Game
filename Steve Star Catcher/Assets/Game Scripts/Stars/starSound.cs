using UnityEngine;
using System.Collections;

public class starSound : MonoBehaviour {
    public AudioSource playStarSound;
    public static AudioSource staticStarSound;

    void Start()
    {
        staticStarSound = playStarSound;
    }

    //public static void PlayStarSound()
    //{
    //    staticStarSound.Play();
    //}
}

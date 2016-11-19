using UnityEngine;
using System.Collections;

public class Movie : MonoBehaviour {

    //public MovieTexture movTexture;
    //void Start()
    //{
    //    GetComponent<Renderer>().material.mainTexture = movTexture;
    //    movTexture.Play();
    //}

    // Use this for initialization
    //void Start()
    //{
    //    ((MovieTexture)GetComponent<Renderer>().material.mainTexture).Play();
    //}

    void Start()
    {
        MovieTexture movie = GetComponent<Renderer>().material.mainTexture as MovieTexture;
        movie.Play();

        
    }


}

using UnityEngine;
using System.Collections;

public class Movie : MonoBehaviour {

    //public GameObject movTexture;
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

    public float minimum = 0.0f;
    public float maximum = 1f;
    public float duration = 5.0f;
    private float startTime;
    private SpriteRenderer sprite;


    void Start()
    {
        MovieTexture movie = GetComponent<Renderer>().material.mainTexture as MovieTexture;
        movie.Play();

        //Renderer rend = GetComponent<Renderer>();
        //rend.material.shader = Shader.Find("Specular");
        //rend.material.SetColor("_SpecColor", Color.red);

        sprite = GetComponent<SpriteRenderer>();

        sprite.color = new Color(0, 0, 0);

        //startTime = Time.time;
    }

    //void Update()
    //{
    //    float t = (Time.time - startTime) / duration;
    //    sprite.color = new Color(1f, 1f, 1f, Mathf.SmoothStep(minimum, maximum, t));
    //}

}

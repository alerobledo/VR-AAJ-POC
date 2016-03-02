using UnityEngine;
using System.Collections;

public class PlayVideo : MonoBehaviour {

    public MovieTexture movie;

	// Use this for initialization
	void Start () {
        gameObject.GetComponent<Renderer>().material.mainTexture = movie as MovieTexture;
        movie.Play();
	}
	
}

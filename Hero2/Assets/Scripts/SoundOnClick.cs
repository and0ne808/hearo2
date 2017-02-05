using UnityEngine;
using System.Collections;

public class SoundOnClick : MonoBehaviour {

    public AudioSource audioSource;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {



        // audio.PlayOneShot( yourAudioclip)


    }

    void OnMouseDown()
    {
        audioSource.Play();

    }
}

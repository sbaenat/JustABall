using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpSound : MonoBehaviour {

    public AudioClip JumpClip;

    public AudioSource JumpSource;

	// Use this for initialization
	void Start () {
        JumpSource.clip = JumpClip;

    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
            JumpSource.Play();
	}
}

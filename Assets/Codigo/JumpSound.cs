using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpSound : MonoBehaviour {

    public AudioClip JumpClip;

    public AudioSource JumpSource;

	void Start () {
        JumpSource.clip = JumpClip;

    }
	
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
            JumpSource.Play();
	}
}

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
        jump();
	}

    void jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            JumpSource.Play();
    }
}

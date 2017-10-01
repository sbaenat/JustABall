using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown()
    {
#pragma warning disable CS0618 // Type or member is obsolete
        Application.LoadLevel ("Level") ;
#pragma warning restore CS0618 // Type or member is obsolete
    }
}

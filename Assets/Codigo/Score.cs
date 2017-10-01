using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour {

    public static int score;

    Text text;

	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();
        score = 35;
	}
	
	// Update is called once per frame
	void Update () {
        text.text = "Score: " + score;
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour {

    public static int score;

    Text text;

	void Start () {
        text = GetComponent<Text>();
        score = 70;
	}
	
	void Update () {
        text.text = "Score: " + score;
	}
}

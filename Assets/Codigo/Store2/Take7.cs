using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Take7 : MonoBehaviour {

    void Start()
    {

    }

    void Update()
    {

    }

    public void OnTriggerEnter(Collider other)
    {
        if (Score.score >= 35)
        {
            Score.score = Score.score - 35;
            tienda.number = 6;
            tienda.changeBall = true;
        }
    }
}

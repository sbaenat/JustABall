using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Take3 : MonoBehaviour {

    void Start()
    {

    }

    void Update()
    {

    }

    public void OnTriggerEnter(Collider other)
    {
        if (Score.score >= 20)
        {
            Score.score = Score.score - 20;
            tienda.number = 2;
            tienda.changeBall = true;
        }
    }
}

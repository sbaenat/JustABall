using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Take2 : MonoBehaviour {

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
            tienda.number = 1;
            tienda.changeBall = true;
        }
    }
}

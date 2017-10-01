using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Take5 : MonoBehaviour {

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
            tienda.number = 4;
            tienda.changeBall = true;
        }
    }
}

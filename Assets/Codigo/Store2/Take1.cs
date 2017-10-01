using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Take1 : MonoBehaviour {

    void Start()
    {

    }

    void Update()
    {

    }

    public void OnTrigger(Collider other)
    {
        if (Score.score >= 0)
        {
            Score.score = Score.score - 0;
            tienda.number = 0;
            tienda.changeBall = true;
        }
    }
}

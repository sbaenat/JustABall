using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camarita : MonoBehaviour {

    public GameObject jugador;
    private Vector3 posicion;


    void Start()
    {
        jugador = GameObject.FindWithTag("Jugador");

        posicion = transform.position - jugador.transform.position;
    }


    void LateUpdate()
    {
        follower();
    }

    void follower()
    {
        jugador = GameObject.FindWithTag("Jugador");

        transform.position = jugador.transform.position + posicion;
    }
}

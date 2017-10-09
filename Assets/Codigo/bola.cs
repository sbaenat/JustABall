using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bola : MonoBehaviour {

    public float velocidad;
    public float altura;
    private int salto;

    private int puntuacion = 5;
    private int puntuacionMaxima = 35;
    private int scoreValue = 5;

    public float temporizador;
    public int temporizadorint;

    public bool ganar = false;
    public bool perder = false;

    public AudioClip JumpClip;

    public AudioSource JumpSource;

    public GameObject yo; 

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        salto = 0;
    }

 
    void FixedUpdate()
    {
        mover();
        saltar();

        controlSalto();
    }

    void Update()
    {
        finJuego();
    }

    void mover()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");


        Vector3 movimiento = new Vector3(x, 0.0f, y);

        if (puntuacion >= puntuacionMaxima || temporizador <= 0)
            {
              movimiento = Vector3.zero;
              rb.velocity = Vector3.Lerp(rb.velocity, Vector3.zero, Time.deltaTime);
            }

            rb.AddForce(movimiento * velocidad);
    }

    void controlSalto()
    {
        if (salto >= 2)
        {
            salto = 1;
        }
    }

    void saltar()
    {
        if (Input.GetButtonDown("Fire3") && salto>=1 )
        {
            JumpSource.Play();

            rb.velocity = new Vector3(0.0f, altura, 0.0f);

            salto = 0;

            if (puntuacion >= puntuacionMaxima || temporizador <= 0)
            {
                rb.velocity = Vector3.zero;
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        salto++;
    }

    void Puntuacion()
    {
        puntuacion++;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            Puntuacion();
            other.gameObject.SetActive(false);
            Score.score += scoreValue;
        }
    }

    void finJuego()
    {
        if (puntuacion < puntuacionMaxima)
        {

            temporizador -= Time.deltaTime;
            temporizadorint = (int)temporizador;
        }

        else
        {
            ganar = true;
            Debug.Log("Has ganado");
        }

        if (temporizador <= 0)
        {
            temporizador = 0;
            perder = true;
            Debug.Log("Has perdido");
        }
        Debug.Log("puntuacion:" + puntuacion + "tiempo:" + temporizador);
    }
}

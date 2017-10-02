using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class tienda : MonoBehaviour {

    public bool[] buy = new bool[8];
    public bool[] select = new bool[8];
    public bool[] get = new bool[8];

    public static int number;
    public static bool changeBall;

    public GameObject[] ball;
    public GameObject[] up;
    public GameObject[] empty;

    void Start()
    {
        number = 0;
        changeBall = true;

    }


    void Update()
    {
        changer();

    }

    public void changer()
    {
        if (changeBall)
        {
            int i = 0;

            Destroy(GameObject.FindWithTag("Jugador"));
            Destroy(GameObject.FindWithTag("Pick Up"));

            Instantiate(ball[number], transform.position, transform.rotation);

            while(i<7)
            {
                if(get[i]==false)
                {
                    Instantiate(up[number], empty[i].transform);
                    i++;
                }
            }

            changeBall = false;
        }
    }
}

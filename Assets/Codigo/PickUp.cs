using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour {

	void Start () {
		
	}
	
	void Update ()
    {
        rotation();
    }

    void rotation()
    {
        transform.Rotate(new Vector3(0, 45, 0) * Time.deltaTime);
    }
}

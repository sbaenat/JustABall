﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotador : MonoBehaviour {

    void Update()
    {
        rotation();
    }

    void rotation()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }
}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class Select6 : MonoBehaviour {

    void Start()
    {

    }

    void Update()
    {
        click();
    }

    public void click()
    {
        if (GetComponent<tienda>().buy[5])
        {
            tienda.number = 5;
            tienda.changeBall = true;
        }
    }
}

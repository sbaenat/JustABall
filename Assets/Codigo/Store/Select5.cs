using UnityEngine;
using System.Collections;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class Select5 : MonoBehaviour {

    void Start()
    {

    }

    void Update()
    {
        click();
    }

    public void click()
    {
        if (GetComponent<tienda>().buy[4])
        {
            tienda.number = 4;
            tienda.changeBall = true;
        }
    }
}

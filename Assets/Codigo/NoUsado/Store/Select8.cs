using UnityEngine;
using System.Collections;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class Select8 : MonoBehaviour {

    void Start()
    {

    }

    void Update()
    {
        click();
    }

    public void click()
    {
        if (GetComponent<tienda>().buy[7])
        {
            tienda.number = 7;
            tienda.changeBall = true;
        }
    }
}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class Select7 : MonoBehaviour {

    void Start()
    {

    }

    void Update()
    {
        click();
    }

    public void click()
    {
        if (GetComponent<tienda>().buy[6])
        {
            tienda.number = 6;
            tienda.changeBall = true;
        }
    }
}

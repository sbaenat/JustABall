using UnityEngine;
using System.Collections;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class Select2 : MonoBehaviour {

    void Start()
    {

    }

    void Update()
    {
        click();
    }

    public void click()
    {
        if (GetComponent<tienda>().buy[1])
        {
            tienda.number = 1;
            tienda.changeBall = true;
        }
    }
}

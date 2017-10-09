using UnityEngine;
using System.Collections;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class Select1 : MonoBehaviour {

	void Start () {
		
	}

    void Update()
    {
        click();
    }

    public void click()
    {
        if (GetComponent<tienda>().buy[0])
        {
            tienda.number = 0;
            tienda.changeBall = true;
        }
    }
}

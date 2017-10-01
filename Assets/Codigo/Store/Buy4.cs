using UnityEngine;
using System.Collections;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class Buy4 : MonoBehaviour {

    void Start()
    {

    }

    void Update()
    {
        click();
    }

    public void click()
    {
        if (Score.score >= 20)
        {
            GetComponent<tienda>().buy[3] = true;
            Score.score = Score.score - 20;
        }
    }
}

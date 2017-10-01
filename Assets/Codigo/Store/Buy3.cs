using UnityEngine;
using System.Collections;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class Buy3 : MonoBehaviour {

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
            GetComponent<tienda>().buy[2] = true;
            Score.score = Score.score - 20;
        }
    }
}

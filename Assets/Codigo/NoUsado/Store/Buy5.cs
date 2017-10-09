using UnityEngine;
using System.Collections;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class Buy5 : MonoBehaviour {

    void Start()
    {

    }

    void Update()
    {
        click();
    }

    public void click()
    {
        if (Score.score >= 35)
        {
            GetComponent<tienda>().buy[4] = true;
            Score.score = Score.score - 35;
        }
    }
}

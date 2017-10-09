using UnityEngine;
using System.Collections;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class NewBehaviourScript : MonoBehaviour {

    void Start () {
        
    }

    void Update()
    {
        Click();
    }

    public void Click()
    {
        if (Score.score >= 0)
        {
            GetComponent<tienda>().buy[0] = true;
            Score.score = Score.score - 0;
        }
    }
}

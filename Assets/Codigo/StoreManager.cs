using System.Collections;
using UnityEngine.UI;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif


public class StoreManager : MonoBehaviour
{

    public Canvas canvas;

    void Start()
    {
        canvas = GetComponent<Canvas>();
        canvas.enabled = false;
    }

    void Update()
    {
        click();
    }

    public void click()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            Pause();
        }
    }

    public void Pause()
    {
        canvas.enabled = !canvas.enabled;
        Time.timeScale = Time.timeScale == 0 ? 1 : 0;
    }

    public void Quit()
    {
#if UNITY_EDITOR
        EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}

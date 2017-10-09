using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour {

    [SerializeField] public string loadLevel;

    public void OnMouseDown()
    {
        SceneManager.LoadScene (loadLevel) ;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
[ExecuteInEditMode]
public class PressSpace : MonoBehaviour {

    void Start() {
        Debug.Log("Loaded main menu!");
    }

    public string levelToLoad = "HowToPlay";

    public void click()
    {
        SceneManager.LoadScene(levelToLoad);
    }
}
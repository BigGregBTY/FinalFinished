using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;

public class TimeText : MonoBehaviour {

	public float numSeconds;

	public Text textToDisable;

	IEnumerator Start () {
		yield return new WaitForSeconds( numSeconds );
		textToDisable.enabled = false;

        LoadNextLevel();
	}

    void LoadNextLevel()
    {
        SceneManager.LoadScene("Lv1");
    }
}

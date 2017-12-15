using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShipManager : MonoBehaviour {
    public int startingLives;
    public int lifeCounter;
    private Text theText;
    

    // Use this for initialization
    void Start () {
        theText = GetComponent<Text>();
        lifeCounter = startingLives;
        
		
	}
	
	// Update is called once per frame
	void Update () {
        theText.text = "x" + lifeCounter;
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCounter : MonoBehaviour {

	GameController mainController;

    void Start() {

        GameController.SharedInstance.EnemySeen();
    }
}
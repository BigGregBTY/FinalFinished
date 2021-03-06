﻿using UnityEngine;
using System.Collections;

public class DestroyByBoundary : MonoBehaviour {

  // We use OnTriggerExit instead of OnTriggerEnter to ensure the object has left the screen before being removed.
  void OnTriggerExit2D(Collider2D other) {
	  if (other.gameObject.tag == "Boundary") {
      if (gameObject.tag == "Player Bullet") {
        gameObject.SetActive(false);
      } else {
        Destroy(gameObject);
      }
    }
  }
}

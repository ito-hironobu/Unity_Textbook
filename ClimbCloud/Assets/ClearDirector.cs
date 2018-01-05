using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // LoadSceneに必要

public class ClearDirector : MonoBehaviour {

	void Start () {
		
	}

	void Update () {
		if (Input.GetMouseButton (0)) {
			SceneManager.LoadScene ("GameScene");
		}
	}
}

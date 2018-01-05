﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	
	void Start () {
		
	}

	public void LButtonDown(){
		transform.Translate (-3, 0, 0);
	}

	public void RButtonDown(){
		transform.Translate (3, 0, 0);
	}

	void Update () {

		// キーボードの左右キー入力で移動
		if (Input.GetKeyDown(KeyCode.LeftArrow)) {
			transform.Translate (-3, 0, 0);
		}

		if (Input.GetKeyDown(KeyCode.RightArrow)) {
			transform.Translate (3, 0, 0);
		}
	}
}

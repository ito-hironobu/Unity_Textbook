using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour {

	private float _speed = 0;
	Vector2 startPos;

	void Start () {
		
	}

	void Update () {

		if (Input.GetMouseButtonDown (0)) {
			startPos = Input.mousePosition;
		} else if (Input.GetMouseButtonUp (0)) {
			Vector2 endPos = Input.mousePosition;
			float swipeLength = endPos.x - startPos.x;

			this._speed = swipeLength / 500.0f;

			// 効果音再生
			GetComponent<AudioSource>().Play();
		}

		transform.Translate (this._speed, 0, 0);
		this._speed *= 0.98f;
	}
}

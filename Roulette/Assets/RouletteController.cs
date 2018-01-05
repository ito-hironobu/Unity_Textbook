using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour {

	private float _rotSpeed = 0; // 回転速度

	void Start () {
		
	}

	void Update () {
		// マウスが押されたら回転速度を設定する
		if (Input.GetMouseButtonDown (0)) {
			this._rotSpeed = 10;
		}

		// 回転速度分、ルーレットを回転させる
		transform.Rotate(0, 0, this._rotSpeed);

		// ルーレットを減速させる
		this._rotSpeed *= 0.96f;
	}
}

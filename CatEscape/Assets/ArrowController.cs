using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour {

	GameObject player;

	void Start () {
		this.player = GameObject.Find ("player");
	}

	void Update () {
		// 等速で落下
		transform.Translate (0, -0.1f, 0);

		// 画面外に出たらオブジェクトを破棄
		if (transform.position.y < -5.0f) {
			Destroy (gameObject);
		}

		// 当たり判定
		Vector2 p1 = transform.position;
		Vector2 p2 = this.player.transform.position;
		Vector2 dir = p1 - p2;
		float d = dir.magnitude;
		float r1 = 0.5f;
		float r2 = 1.0f;

		if (d < r1 + r2) {
			// 監督スクリプトに衝突を伝えてHPゲージを減らす
			GameObject director = GameObject.Find("GameDirector");
			director.GetComponent<GameDirector> ().DecreaseHp ();

			// 矢を削除
			Destroy (gameObject);
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
	private int _hp = 100;
	private int _power = 50;

	public void Attack()
	{
		Debug.Log (_power + "のダメージを与えた");
	}

	public void Damage(int damage)
	{
		_hp -= damage;
		Debug.Log (damage + "のダメージを受けた");
	}
}

public class Test : MonoBehaviour {

	void Start () {
		Player myPlayer = new Player ();
		myPlayer.Attack ();
		myPlayer.Damage (30);
		Vector2 v2 = new Vector2 (2.0f, 2.0f);
	}
}

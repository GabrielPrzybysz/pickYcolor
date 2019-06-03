using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	private Rigidbody2D _rig;

	public float Speed;

	// Use this for initialization
	void Start () {
		_rig = GetComponent<Rigidbody2D> ();
	}

	// Update is called once per frame
	void Update () {

		float moveX = Input.GetAxis ("Horizontal");
		float moveY = Input.GetAxis ("Vertical");

		Vector2 movement = new Vector2 (moveX, moveY);
		_rig.AddForce (movement * Speed);
	}
}
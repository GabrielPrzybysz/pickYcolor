using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lose : MonoBehaviour {

	[SerializeField] private GameObject LoseString;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame

	void Update () {
		if (ColorSpawner.lose == true) {
			
			LoseString.SetActive (true);
		}
	}
}
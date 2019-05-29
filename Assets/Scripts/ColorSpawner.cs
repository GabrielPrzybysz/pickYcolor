using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSpawner : MonoBehaviour {

	public GameObject[] CubeColor;


	//Leave public for debug 12092003
	public bool _spawn = true;

	void Start () {

	}

	void Update () {
		if (_spawn) {
			for (int x = 0; x < CubeColor.Length; x++) {
				Instantiate (CubeColor[x], new Vector3 (Random.Range (-15.94f, 15.94f), Random.Range (-7.7f, 7.7f), 1), Quaternion.identity);
			}
			_spawn = false;
		}
	}
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorSpawner : MonoBehaviour {

	public float timer;
	//Leave public for debug 12092003
	public static bool _spawn = true;
	//end
	public static bool lose = false;
	public static bool ChangeColor = false;

	[SerializeField] private GameObject[] CubeColor;
	[SerializeField] private string[] NameColors = new string[4];
	[SerializeField] private Text colors;
	[SerializeField] private GameObject canvasText;
	[SerializeField] private Color[] NewColors;

	private void Start () {
		ChangeColorName ();
	}

	private void Update () {
		if (lose == false) {
			if (ChangeColor == true) {
				ChangeColorName ();
				ChangeColor = false;
			}

			if (_spawn) {
				for (int x = 0; x < CubeColor.Length; x++) {
					Instantiate (CubeColor[x], new Vector3 (Random.Range (-15.94f, 15.94f), Random.Range (-7.7f, 7.7f), 1), Quaternion.identity);
				}
				_spawn = false;
			}
		}
	}

	void ChangeColorName () {
		colors.text = NameColors[Random.Range (0, 3)];
		colors.color = NewColors[Random.Range (0, 3)];
		canvasText.SetActive (true);
	}
}
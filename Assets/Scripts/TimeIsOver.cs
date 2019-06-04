using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeIsOver : MonoBehaviour {

	[SerializeField] public Slider slider;
	[SerializeField] private float MaxTime = 10f;

	public static bool reset = false;
	// Use this for initialization
	void Start () {
		slider.maxValue = MaxTime;
		slider.minValue = 0;
		slider.value = MaxTime;
	}

	// Update is called once per frame
	void Update () {

		if (reset == true) {
			slider.value = 10;
			reset = false;
		}
		if (ColorSpawner.lose == false) 
		{
			if (slider.value > 0) 
			{
				slider.value -= Time.deltaTime;
			}
		}
		if (slider.value <= 0) {
			ColorSpawner.lose = true;
		}
	}
}
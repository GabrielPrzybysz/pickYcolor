using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorSpawner : MonoBehaviour {

    public float timer;
    public static bool lose = false;
    public static bool ChangeColor = false;

    [SerializeField] private GameObject[] CubeColor;
    [SerializeField] private string[] NameColors;
    [SerializeField] private Text colors;
    [SerializeField] private GameObject canvasText;
    [SerializeField] private Color[] NewColors;

    private void Start () {
        ChangeColorName ();
        for (int x = 0; x < CubeColor.Length; x++) {
            Instantiate (CubeColor[x], new Vector3 (Random.Range (-15.94f, 15.94f), Random.Range (-7.7f, 7.7f), 1f), Quaternion.identity);
        }
    }

    private void Update () {

        if (lose == false) {
            if (ChangeColor == true) {
                ChangeColorName ();
                for (int x = 0; x < CubeColor.Length; x++) {
                    Instantiate (CubeColor[x], new Vector3 (Random.Range (-15.94f, 15.94f), Random.Range (-7.7f, 7.7f), 1f), Quaternion.identity);
                }
                ChangeColor = false;
            }

        }
    }

    void ChangeColorName () {
        colors.text = NameColors[Random.Range (0, NameColors.Length)];
        colors.color = NewColors[Random.Range (0, CubeColor.Length)];
        canvasText.SetActive (true);
    }
}

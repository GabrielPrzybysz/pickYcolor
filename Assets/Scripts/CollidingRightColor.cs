using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollidingRightColor : MonoBehaviour
{

    public Text RightColorName;
    public Text Points;
    private int CountPoints = 0;

    void Start()
    {
        Points.text = CountPoints.ToString();
    }

    void Update()
    {
        Points.text = "Score " + CountPoints.ToString();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "cube_" + RightColorName.text + "(Clone)" && ColorSpawner.lose == false)
        {
            Destroy(col.gameObject);
            CountPoints += 10;
            ColorSpawner._spawn = true;
            ColorSpawner.ChangeColor = true;
        }
        else if (col.gameObject.name != "Background")
        {
            ColorSpawner.lose = true;
        }
    }

}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Lose : MonoBehaviour
{

    public static bool RestarNowSpawn = false;

    [SerializeField] private GameObject LosePanel;
    

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame

    void Update()
    {
        if (ColorSpawner.lose == true)
        {
            LosePanel.SetActive(true);
        }
    }

    public void Restart()
    {
        StartCoroutine(LoadRestart());
        ColorSpawner.lose = false;
        
    }

    IEnumerator LoadRestart ()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync("stage_01");
        while (!operation.isDone)
        {
            Debug.Log(operation.progress);
            yield return null;
        }
        ColorSpawner._spawn = true;
    }

 
}
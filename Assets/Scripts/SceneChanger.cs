using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public static bool clearMedals;
    public string scene;
    public void LoadScene()
    {
        SceneManager.LoadScene(scene);

    }

    public void DisableMedalHeads()
    {
        clearMedals = true;
    }
    public void QuitApp()
    {
        Application.Quit();
    }
    void Start()
    {
        clearMedals = false;
    }

    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public static bool clearMedals;
    public string scene;
    public void loadScene()
    {
        SceneManager.LoadScene(scene);

       clearMedals = true;
        
    }

    public void quitApp()
    {
        Application.Quit();
    }
    void Start()
    {
        //clearMedals = false;
    }

    void Update()
    {
        
    }
}

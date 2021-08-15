using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public string scene;
    public void loadScene()
    {
        SceneManager.LoadScene(scene);
    }

    public void quitApp()
    {
        Application.Quit();
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}

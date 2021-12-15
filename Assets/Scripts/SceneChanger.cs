using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public string scene;
    public void LoadScene()
    {
        SceneManager.LoadScene(scene);

        // To prevent new medal showing and the previous disappear
        // after one has been achieved and returing from another game without finishing:
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            MedalManager.hasPlayed =false;
        }
    }

    public void DisableMedalHeads()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        if (currentScene == 0)
        {
            GlobalScript.hideAllMedals = true;
            Debug.Log("clearMedals = " + GlobalScript.hideAllMedals);
        }
    }
    public void QuitApp()
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

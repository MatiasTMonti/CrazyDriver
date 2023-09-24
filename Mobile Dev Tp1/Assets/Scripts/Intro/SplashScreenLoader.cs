using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreenLoader : MonoBehaviour
{
    private void Start()
    {
        LoadMenu();
    }

    public void LoadMenu()
    {
        StartCoroutine(LoadScene());
    }

    private IEnumerator LoadScene()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync("MainMenu");
        operation.allowSceneActivation = false;
        while (!operation.isDone)
        {
            operation.allowSceneActivation = true;
            yield return null;
        }
    }
}

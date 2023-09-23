using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] DifficultyScriptableObject difficulty;

    public void ChangeScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void ChangeDifficulty(int diff)
    {
        difficulty.currentDifficulty = (Difficulty)diff;
    }

    public void PauseGame()
    {
        Time.timeScale = Time.timeScale == 0 ? 1 : 0;
    }

    public void PauseGame(GameObject panel)
    {
        Time.timeScale = Time.timeScale == 0 ? 1 : 0;
        panel.SetActive(!panel.activeSelf);
    }
}

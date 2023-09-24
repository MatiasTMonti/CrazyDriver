using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] DifficultyScriptableObject difficulty;
    [SerializeField] MultiplayerScriptableObject multiplayer;

    private void Start()
    {
        Time.timeScale = 1;
        GameManager.OnEndgame += ChangeSceneEndGame;
    }

    private void OnDestroy()
    {
        GameManager.OnEndgame -= ChangeSceneEndGame;
    }

    public void ChangeScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void ChangeDifficulty(int diff)
    {
        difficulty.currentDifficulty = (Difficulty)diff;
    }

    public void ChangeMultiplayer(bool multi)
    {
        multiplayer.isMultiplayer = multi;
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

    public void ChangeSceneEndGame()
    {
        if (multiplayer.isMultiplayer)
        {
            SceneManager.LoadScene("EndGameMultiPlayer");
        }
        else
        {
            SceneManager.LoadScene("EndGameSinglePlayer");
        }
    }
}

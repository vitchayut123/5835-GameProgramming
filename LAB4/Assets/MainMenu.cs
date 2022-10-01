using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        int LevelIndex = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(LevelIndex);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
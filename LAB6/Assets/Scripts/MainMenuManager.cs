using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(1);
        DOTween.KillAll();
    }

    public void QuitGame()
    {
        Application.Quit();
        DOTween.KillAll();
    }
}

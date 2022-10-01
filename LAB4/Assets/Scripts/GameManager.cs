using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;


public class GameManager : MonoBehaviour
    
{
    // Simple singleton script. This is the easiest way to create and understand a singleton script.
    [SerializeField] private HealthDisplay displayPlayerlife;
    [SerializeField] private int life = 3;

    private void Awake()
    {
        var numGameManager = FindObjectsOfType<GameManager>().Length;

        if (numGameManager > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            displayPlayerlife.LifeUpdate(life);
            DontDestroyOnLoad(gameObject);
        }
    }

    public void ProcessPlayerDeath()
    {
        //SceneManager.LoadScene(GetCurrentBuildIndex());
        life--;
        displayPlayerlife.LifeUpdate(life);
        if (life == 0)
        {
            LoadMenu();
        }
        else
        {
            LoadLevel(GetCurrentBuildIndex());
        }
    }

    public void LoadLevel(int LevelIndex)
    {
        SceneManager.LoadScene(LevelIndex);
        DOTween.KillAll();
    }

    public void LoadMenu()
    {
        LoadLevel(0);
        Destroy(gameObject);
    }
    public void LoadNextLevel()
    {
        var nextSceneIndex = GetCurrentBuildIndex() + 1;

        if (nextSceneIndex == SceneManager.sceneCountInBuildSettings)
        {
            nextSceneIndex = 0;
        }

        LoadLevel(nextSceneIndex);
        DOTween.KillAll();
    }

    private int GetCurrentBuildIndex()
    {
        return SceneManager.GetActiveScene().buildIndex;
    }
}
using System.Collections;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private UIManager uiManager;
    [SerializeField] private int playerLives = 3;
    [SerializeField] private float timeBeforeSceneChange = 1.5f;
    // Simple singleton script. This is the easiest way to create and understand a singleton script.
    
    private void Awake()
    {
        var numGameManager = FindObjectsOfType<GameManager>().Length;

        if (numGameManager > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    private void Start()
    {
        UpdateLives();
    }
    
    public void ProcessPlayerDeath()
    {
        playerLives--;
        
        switch (playerLives)
        {
            case >= 1:
                LoadScene(GetCurrentBuildIndex());
                UpdateLives();
                break;
            default:
                ReturnToMainMenu();
                break;
        }
    }

    public void ReturnToMainMenu()
    {
        LoadScene(0);
    }
    
    public void LoadNextLevel()
    {
        var nextSceneIndex = GetCurrentBuildIndex() + 1;
        
        if (nextSceneIndex == SceneManager.sceneCountInBuildSettings)
        {
            nextSceneIndex = 1;
        }
        
        LoadScene(nextSceneIndex);
    }

    private int GetCurrentBuildIndex()
    {
        return SceneManager.GetActiveScene().buildIndex;
    }

    private void LoadScene(int buildIndex)
    {
        StartCoroutine(BeginSceneLoad(buildIndex));
    }

    private IEnumerator BeginSceneLoad(int buildIndex)
    {
        yield return new WaitForSeconds(timeBeforeSceneChange);
        SceneManager.LoadScene(buildIndex);
        DOTween.KillAll();

        if (buildIndex != 0) yield break;
        Destroy(gameObject);
    }

    private void UpdateLives()
    {
        uiManager.UpdateLives(playerLives);
    }
}

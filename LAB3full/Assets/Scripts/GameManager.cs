using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this);
        }else
        {
            instance = this;
        }
    }


    public void ProcessPlayerDeath()
    {
        SceneManager.LoadScene(GetScene());
    }


    private int GetScene()
    {
        return SceneManager.GetActiveScene().buildIndex;
    }


    public void LoadLevel(int levelIndex)
    {
        SceneManager.LoadScene(levelIndex);
    }


    public void LoadNextLevel()
    {
        int nextSceneBuildIndex = SceneManager.GetActiveScene().buildIndex + 1;
        if(nextSceneBuildIndex == SceneManager.sceneCountInBuildSettings)
        {
            LoadLevel(0);
        }
        else
        {
            SceneManager.LoadScene(nextSceneBuildIndex);
        }
    }    
}

using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public string gameSceneName;

    public void StartGame()
    {
        SceneManager.LoadScene(gameSceneName);
    }
}

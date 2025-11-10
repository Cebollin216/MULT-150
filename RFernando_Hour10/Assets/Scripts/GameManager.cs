using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager I;  // easy access

    [Header("UI References")]
    public Text scoreText;
    public Text livesText;
    public Text winText;
    public GameObject restartButton;
    public Timer timer;

    [Header("Gameplay Settings")]
    public GameObject pickupsParent;

    int score = 0;
    int lives = 3;
    int totalPickups;

    void Awake()
    {
        if (I == null) I = this;
        else Destroy(gameObject);
    }

    void Start()
    {
        // Count total pickups
        if (pickupsParent != null)
            totalPickups = pickupsParent.GetComponentsInChildren<Pickup>(false).Length;
        else
            totalPickups = FindObjectsOfType<Pickup>().Length;

        // UI init
        if (winText) winText.gameObject.SetActive(false);
        if (restartButton) restartButton.SetActive(false);

        // timer starts running
        if (timer) timer.running = true;

        UpdateUI();
    }

    // ========= Public API =========
    public void AddScore(int value)
    {
        score += value;  // supports big pickups (value=3) and small (value=1)
        UpdateUI();

        // Win when ALL pickups are collected
        int remaining = RemainingPickups();
        if (remaining <= 0)
            Win();
    }

    public void LoseLife()
    {
        lives--;
        UpdateUI();

        if (lives <= 0)
        {
            GameOver();
            return;
        }
    }

    // ========= UI Update =========
    void UpdateUI()
    {
        int remaining = RemainingPickups();
        int collected = totalPickups - remaining;

        if (scoreText)
            scoreText.text = $"Pickups: {collected}/{totalPickups}   Points: {score}";

        if (livesText)
            livesText.text = $"Lives: {lives}";
    }

    // ========= Game Flow =========
    public void Win()
    {
        Debug.Log("WIN called!");
        if (timer) timer.Stop();
        if (winText)
            winText.text = "YOU WIN!\nTime: " + timer.GetTime().ToString("F1") + "s";
        if (winText) winText.gameObject.SetActive(true);
        if (restartButton) restartButton.SetActive(true);
        Time.timeScale = 0f;
    }

    public void GameOver()
    {
        Debug.Log("GAME OVER called!");
        if (timer) timer.Stop();
        if (winText)
            winText.text = "GAME OVER!";
        if (winText) winText.gameObject.SetActive(true);
        if (restartButton) restartButton.SetActive(true);
        Time.timeScale = 0f;
    }

    public void RestartLevel()
    {
        Time.timeScale = 1f;
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.buildIndex);
    }

    int RemainingPickups()
    {
        return FindObjectsOfType<Pickup>().Length;
    }
}

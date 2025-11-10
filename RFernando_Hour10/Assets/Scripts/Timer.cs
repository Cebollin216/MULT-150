using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerText;      // drag TimerText here
    public bool running = true; // GameManager will stop this on win/lose
    float elapsed;

    void Update()
    {
        if (!running || Time.timeScale == 0f) return;
        elapsed += Time.deltaTime;
        if (timerText) timerText.text = "Time: " + elapsed.ToString("F1") + "s";
    }

    public float GetTime() => elapsed;
    public void Stop() { running = false; }
}

using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

/// <summary>
/// Manages the game timer.
/// </summary>
public class TimerScript : MonoBehaviour
{
    [SerializeField] private float totalTime = 60f;
    [SerializeField] private TMP_Text timerText;

    private float elapsedGameTime;

    /// <summary>
    /// Gets the elapsed time since the game started.
    /// </summary>
    public static float ElapsedTime { get; private set; }

    /// <summary>
    /// Called when the script instance is being loaded.
    /// </summary>
    private void Start()
    {
        // Initialize the timer at the start.
        InitializeTimer();
    }

    /// <summary>
    /// Called once per frame.
    /// </summary>
    private void Update()
    {
        // Update the timer every frame.
        UpdateTimer();
        // Check if the game is over.
        CheckGameOver();
    }

    /// <summary>
    /// Initializes the timer with the starting time.
    /// </summary>
    private void InitializeTimer()
    {
        // Set the timer text to display the initial time.
        timerText.text = "Timer: " + Mathf.Round(totalTime);
    }

    /// <summary>
    /// Updates the timer every frame.
    /// </summary>
    private void UpdateTimer()
    {
        // Calculate the remaining time and update the text.
        float remainingTime = totalTime - elapsedGameTime;
        remainingTime = Mathf.Max(remainingTime, 0f);
        timerText.text = "Timer: " + Mathf.Round(remainingTime);
        // Increment the elapsed time.
        elapsedGameTime += Time.deltaTime;
        // Update the ElapsedTime variable to allow access from other scripts.
        ElapsedTime = elapsedGameTime;
    }

    /// <summary>
    /// Checks if the game is over and loads the "GameOver" scene.
    /// </summary>
    private void CheckGameOver()
    {
        // Load the "GameOver" scene if the time is up.
        if (elapsedGameTime >= totalTime)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}

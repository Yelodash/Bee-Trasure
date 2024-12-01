using UnityEngine;
using TMPro;

/// <summary>
/// Manages the victory scene, displaying victory information.
/// </summary>
public class TimeScriptVictory : MonoBehaviour
{
    [SerializeField] private TMP_Text victoryText;

    /// <summary>
    /// Called when the script instance is being loaded.
    /// </summary>
    private void Start()
    {
        // Display the victory time at the beginning.
        DisplayVictoryTime();
    }

    /// <summary>
    /// Displays the victory time on the UI.
    /// </summary>
    private void DisplayVictoryTime()
    {
        // Get the victory time from the TimerScript.
        float victoryTime = TimerScript.ElapsedTime;
        // Update the victory text with the formatted time.
        UpdateVictoryText(victoryTime);
    }

    /// <summary>
    /// Updates the victory text with the formatted time.
    /// </summary>
    /// <param name="time">The victory time to be displayed.</param>
    private void UpdateVictoryText(float time)
    {
        // Update the victory text with the formatted time.
        victoryText.text = FormatVictoryText(time);
    }

    /// <summary>
    /// Formats the victory time for display.
    /// </summary>
    /// <param name="time">The victory time to be formatted.</param>
    /// <returns>The formatted victory time as a string.</returns>
    private string FormatVictoryText(float time)
    {
        // Format the victory time for display.
        return "Record: " + Mathf.Round(time) + " seconds";
    }
}

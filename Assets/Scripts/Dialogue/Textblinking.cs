using UnityEngine;
using TMPro;

/// <summary>
/// Makes a TextMeshProUGUI text blink by toggling its visibility at a specified interval.
/// </summary>
public class TextBlinking : MonoBehaviour
{
    /// <summary>
    /// The TextMeshProUGUI component to be made to blink.
    /// </summary>
    public TextMeshProUGUI textMeshPro;
    
    /// <summary>
    /// The interval at which the text blinks, in seconds.
    /// </summary>
    public float blinkInterval = 0.5f;

    private Color originalColor;
    private bool isTextVisible = true;

    /// <summary>
    /// Initializes the script by setting the original color and starting the blinking coroutine.
    /// </summary>
    private void Start()
    {
        originalColor = textMeshPro.color;
        InvokeRepeating(nameof(ToggleVisibility), blinkInterval, blinkInterval);
    }

    /// <summary>
    /// Toggles the visibility of the text by changing its color.
    /// </summary>
    private void ToggleVisibility()
    {
        isTextVisible = !isTextVisible;
        textMeshPro.color = isTextVisible ? originalColor : Color.clear;
    }
}

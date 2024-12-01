using UnityEngine;
using TMPro;

/// <summary>
/// Manages the display and manipulation of the coin count on the UI canvas.
/// </summary>
public class CoinCanvas : MonoBehaviour
{
    private static CoinCanvas instance;
    private int currentCoins = 0;
    public TMP_Text coinText;

    // Singleton pattern: Public property to access the instance
    public static CoinCanvas Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<CoinCanvas>();
            }
            return instance;
        }
    }

    // Property to access the TMP_Text component
    private TMP_Text CoinText
    {
        get
        {
            if (coinText == null)
            {
                coinText = GetComponentInChildren<TMP_Text>();
            }
            return coinText;
        }
    }

    // Method called at the start 
    private void Start()
    {
        // Initialize the coin count text
        UpdateCoinText();
    }

    /// <summary>
    /// Updates the text displaying the coin count.
    /// </summary>
    private void UpdateCoinText()
    {
        if (CoinText != null)
        {
            CoinText.text = $"COINS : {currentCoins}";
        }
    }

    /// <summary>
    /// Increases the coin count by the specified value and updates the UI.
    /// </summary>
    /// <param name="value">The value by which to increase the coin count.</param>
    public void IncreaseCoins(int value)
    {
        currentCoins += value;
        UpdateCoinText();
    }
}

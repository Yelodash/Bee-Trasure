using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Represents a collectible coin in the game.
/// </summary>
public class Coin : MonoBehaviour
{
    private int value = 1;
    private static int totalCoinsCollected = 0;

    // Reference to the AudioManager instance
    private static AudioManager audioManager;

    // Static method to set the AudioManager instance
    public static void SetAudioManager(AudioManager manager)
    {
        audioManager = manager;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (IsPlayer(other))
        {
            CollectCoin();
            audioManager.PlaySFX(audioManager.coinCollect);
        }
    }
    
    
    /// <summary>
    /// Collects the coin, increases the total coin count, and checks for win condition.
    /// </summary>
    private void CollectCoin()
    {
        // Destroy the coin GameObject.
        Destroy(gameObject);
        // Increase the coin count displayed on the UI.
        CoinCanvas.Instance.IncreaseCoins(value);
        // Increment the total coins collected.
        totalCoinsCollected++;

        // Check if the total coins collected equals the win condition.
        if (totalCoinsCollected == 13)
        {
            // Handle the win condition.
            HandleWinCondition();
        }
    }

    /// <summary>
    /// Handles the win condition by loading the GG scene and resetting the total coins collected.
    /// </summary>
    private void HandleWinCondition()
    {
        // Load the GG scene.
        SceneManager.LoadScene("GG");
        // Reset the total coins collected.
        ResetTotalCoinsCollected();
    }

    /// <summary>
    /// Resets the total coins collected.
    /// </summary>
    public static void ResetTotalCoinsCollected()
    {
        totalCoinsCollected = 0;
    }

    /// <summary>
    /// Checks if the collider belongs to the player.
    /// </summary>
    /// <param name="other">The collider to check.</param>
    /// <returns>True if the collider belongs to the player, false otherwise.</returns>
    private bool IsPlayer(Collider2D other)
    {
        // Check if the collider's tag is "Player".
        return other.CompareTag("Player");
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Script which handlse collisions with spikes.
/// </summary>
public class SpikeScript : MonoBehaviour
{
    /// <summary>
    /// Called when another collider enters the trigger collider attached to this object.
    /// </summary>
    /// <param name="other">The Collider2D that entered the trigger.</param>
    private void OnTriggerEnter2D(Collider2D other)
    {
        HandlePlayerCollision(other);
    }

    /// <summary>
    /// Handles collision with the player.
    /// </summary>
    /// <param name="other">The Collider2D involved in the collision.</param>
    private void HandlePlayerCollision(Collider2D other)
    {
        if (IsPlayer(other))
        {
            LoadGameOverScene();
        }
    }

    /// <summary>
    /// Checks if the collider belongs to the player.
    /// </summary>
    /// <param name="other">The Collider2D to check.</param>
    /// <returns>True if the Collider2D belongs to the player, false otherwise.</returns>
    private bool IsPlayer(Collider2D other)
    {
        return other.CompareTag("Player");
    }

    /// <summary>
    /// Loads the game over scene.
    /// </summary>
    private void LoadGameOverScene()
    {
        SceneManager.LoadScene("GameOver");
    }
}

using UnityEngine;

public class Player : Character
{
    // Overload the Start method to add player-specific behaviour
    protected override void Start()
    {
        base.Start(); // Call the base class's Start method
    }

    // Overload the Update method to add player-specific behaviour
    protected override void Update()
    {
        base.Update(); // Call the base class's Update method

        // Add player-specific logic here
        ManagePlayerSFX(); // Call the method to manage player-specific SFX
    }

    // Overload the OnCollisionEnter2D method to add player-specific behaviour
    protected override void OnCollisionEnter2D(Collision2D collision)
    {
        base.OnCollisionEnter2D(collision); // Call the base class's OnCollisionEnter2D method
    }

    // Method to handle player-specific SFX
    protected void ManagePlayerSFX()
    {
        //Check if the player is moving and play the movement SFX
        if (isMoving && !audioManager.IsSFXPlaying(audioManager.movement))
        {
            audioManager.PlaySFX(audioManager.movement);
        }
        //Check if the player stops moving and stop the movement SFX
        else if (!isMoving && audioManager.IsSFXPlaying(audioManager.movement))
        {
            audioManager.StopSFX(audioManager.movement);
        }

        // Check if the player collects a coin and play the coin collect SFX
        if (audioManager.IsSFXPlaying(audioManager.coinCollect) && audioManager.IsSFXPlaying(audioManager.movement))
        {
            audioManager.StopSFX(audioManager.movement);
        }
    }
}

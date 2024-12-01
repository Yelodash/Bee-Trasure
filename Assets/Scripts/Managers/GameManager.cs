using UnityEngine;

/// <summary>
/// Manages game-related functionalities.
/// </summary>
public class GameManager : MonoBehaviour
{
    private AudioManager audioManager;

    /// <summary>
    /// Initializes the GameManager instance.
    /// </summary>
    private void Awake()
    {
    
        audioManager = FindObjectOfType<AudioManager>();
        if (audioManager == null)
        {
          
            GameObject audioManagerObject = new GameObject("AudioManager");
            audioManager = audioManagerObject.AddComponent<AudioManager>();
        }

      
        Coin.SetAudioManager(audioManager);
    }
}

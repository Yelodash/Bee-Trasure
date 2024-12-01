using UnityEngine;

/// <summary>
/// AudioManager handles playing background music and sound effects.
/// </summary>
public class AudioManager : MonoBehaviour
{
    private static AudioManager instance;

    /// <summary>
    /// Provides access to the singleton instance of AudioManager.
    /// </summary>
    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject); // Prevent duplicate instances
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject); // Keep the AudioManager across scenes
    }

    [Header("Audio Sources")]
    [SerializeField] private AudioSource musicSource;
    [SerializeField] private AudioSource SFXSource;

    [Header("Audio Clips")]
    public AudioClip coinCollect;
    public AudioClip background;
    public AudioClip movement;
    

    [Header("Volume Settings")]
    [Range(0f, 1f)]
    [SerializeField] private float musicVolume = 1f;
    [Range(0f, 1f)]
    [SerializeField] private float SFXVolume = 1f;

    private void Start()
    {
        PlayBackgroundMusic();
    }

    /// <summary>
    /// Plays the specified sound effect once.
    /// </summary>
    /// <param name="clip">The AudioClip to play.</param>
    public void PlaySFX(AudioClip clip)
    {
        if (clip == null)
        {
            Debug.LogWarning("Trying to play a null AudioClip.");
            return;
        }

        Debug.Log("Playing SFX: " + clip.name);
        SFXSource.PlayOneShot(clip, SFXVolume);
    

        Debug.Log("Playing SFX: " + clip.name);
        SFXSource.clip = clip;
        SFXSource.loop = false;
        SFXSource.volume = SFXVolume;
        SFXSource.Play();
    }

    /// <summary>
    /// Stops playing the specified sound effect.
    /// </summary>
    /// <param name="clip">The AudioClip to stop.</param>
    public void StopSFX(AudioClip clip)
    {
        if (clip == null)
        {
            Debug.LogWarning("Trying to stop a null AudioClip.");
            return;
        }

        Debug.Log("Stopping SFX: " + clip.name);
        if (IsSFXPlaying(clip))
        {
            SFXSource.Stop();
        }
    }

    /// <summary>
    /// Sets the volume of the background music.
    /// </summary>
    /// <param name="volume">The volume level (0 to 1).</param>
    public void SetMusicVolume(float volume)
    {
        Debug.Log("Setting music volume to: " + volume);
        musicVolume = Mathf.Clamp01(volume); // Clamp between 0 and 1
        musicSource.volume = musicVolume;
    }

    /// <summary>
    /// Sets the volume of sound effects.
    /// </summary>
    /// <param name="volume">The volume level (0 to 1).</param>
    public void SetSFXVolume(float volume)
    {
        Debug.Log("Setting SFX volume to: " + volume);
        SFXVolume = Mathf.Clamp01(volume); // Clamp between 0 and 1
    }

    private void PlayBackgroundMusic()
    {
        if (background != null)
        {
            Debug.Log("Playing background music: " + background.name);
            musicSource.clip = background;
            musicSource.volume = musicVolume;
            musicSource.loop = true;
            musicSource.Play();
        }
        else
        {
            Debug.LogWarning("No background music assigned to AudioManager.");
        }
    }

    /// <summary>
    /// Checks if the specified sound effect is currently playing.
    /// </summary>
    /// <param name="clip">The AudioClip to check.</param>
    /// <returns>True if the specified sound effect is playing, false otherwise.</returns>
    public bool IsSFXPlaying(AudioClip clip)
    {
        return SFXSource.isPlaying && SFXSource.clip == clip;
    }
    
    public void PlayCoinCollectSound()
    {
        if (coinCollect != null)
        {
            Debug.Log("Playing coin collect sound: " + coinCollect.name);
            SFXSource.clip = coinCollect;
            SFXSource.Play();
        }
        else
        {
            Debug.LogWarning("Coin collect sound is not assigned.");
        }
    }
}

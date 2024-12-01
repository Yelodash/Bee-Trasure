using UnityEngine.SceneManagement;

/// <summary>
///Command for starting the game.
/// </summary>
public class PlayGameCommand : IMenuCommand
{
    /// <summary>
    /// Loads the 'Game' scene.
    /// </summary>
    public void Execute()
    {
        SceneManager.LoadScene("Game");
    }
}

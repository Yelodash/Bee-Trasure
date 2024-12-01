using UnityEngine;


/// <summary>
/// Manages the main menu functionality.
/// </summary>
public class GameOverMenu : MonoBehaviour
{
    private IMenuCommand playCommand;
    private IMenuCommand quitCommand;

    private void Start()
    {
        playCommand = new PlayGameCommand();
        quitCommand = new QuitGameCommand();
    }

    /// <summary>
    /// Method called by the "Play" button. Executes the play command.
    /// </summary>
    public void TryAgain()
    {
        playCommand.Execute();
    }

    /// <summary>
    /// Method called by the "Quit" button. Executes the quit command.
    /// </summary>
    public void QuitGame()
    {
        quitCommand.Execute();
    }
}

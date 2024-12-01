using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Concrete command for quitting the game.
/// </summary>
public class QuitGameCommand : IMenuCommand
{
    /// <summary>
    /// Quits the application.
    /// </summary>
    public void Execute()
    {
        Application.Quit();
    }
}

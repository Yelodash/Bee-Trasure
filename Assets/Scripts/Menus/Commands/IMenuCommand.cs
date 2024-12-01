using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Concrete command for starting the game.
/// </summary>
public interface IMenuCommand
{
    /// <summary>
    /// Executes the command.
    /// </summary>
    void Execute();
}

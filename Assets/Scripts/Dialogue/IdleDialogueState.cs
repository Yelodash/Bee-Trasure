using UnityEngine;
using System.Collections;

/// <summary>
/// Represents the state where no dialogue is actively being displayed or processed.
/// </summary>
public class IdleDialogueState : IDialogueState
{
    private DialogueManager dialogueManager;

    /// <summary>
    /// Initializes a new instance of the <see cref="IdleDialogueState"/> class.
    /// </summary>
    /// <param name="manager">The DialogueManager instance managing this state.</param>
    public IdleDialogueState(DialogueManager manager)
    {
        dialogueManager = manager;
    }

    /// <summary>
    /// Executes when entering the idle dialogue state (does nothing).
    /// </summary>
    public void EnterState()
    {
        // Do nothing
    }

    /// <summary>
    /// Updates the state (does nothing).
    /// </summary>
    public void UpdateState()
    {
        // Do nothing
    }
}

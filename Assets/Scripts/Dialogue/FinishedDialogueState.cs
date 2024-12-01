using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Represents the state when the dialogue has finished and is ready to be ended.
/// </summary>
/// 
public class FinishedDialogueState : IDialogueState
{
    private DialogueManager dialogueManager;

    /// <summary>
    /// Initializes a new instance of the <see cref="FinishedDialogueState"/> class.
    /// </summary>
    /// <param name="manager">The DialogueManager instance managing this state.</param>
    public FinishedDialogueState(DialogueManager manager)
    {
        dialogueManager = manager;
    }

    /// <summary>
    /// Executes when entering the finished dialogue state, ending the dialogue.
    /// </summary>
    public void EnterState()
    {
        dialogueManager.EndDialogue();
    }

    /// <summary>
    /// Updates the state (does nothing in this state).
    /// </summary>
    public void UpdateState()
    {
        
    }
}

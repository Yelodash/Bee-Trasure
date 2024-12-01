using UnityEngine;

/// <summary>
/// Represents the state where dialogue sentences are being displayed.
/// </summary>
public class DisplayingDialogueState : IDialogueState
{
    private DialogueManager dialogueManager;

    /// <summary>
    /// Initializes a new instance of the <see cref="DisplayingDialogueState"/> class.
    /// </summary>
    /// <param name="manager">The DialogueManager instance managing this state.</param>
    public DisplayingDialogueState(DialogueManager manager)
    {
        dialogueManager = manager;
    }

    /// <summary>
    /// Executes when entering the displaying dialogue state, displaying the next sentence.
    /// </summary>
    public void EnterState()
    {
        dialogueManager.DisplayNextSentence();
    }

    /// <summary>
    /// Updates the state, checking for user input to advance or end the dialogue.
    /// </summary>
    public void UpdateState()
    {
        if (Input.GetKeyDown(KeyCode.E)) 
        {
            dialogueManager.DisplayNextSentence();
        }
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            dialogueManager.EndDialogue();
        }
    }
}

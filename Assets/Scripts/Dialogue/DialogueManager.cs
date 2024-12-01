using UnityEngine;
using TMPro;

/// <summary>
/// Manages the display and  of dialogues in the game.
/// </summary>
public class DialogueManager : MonoBehaviour
{
    /// <summary>
    /// The TextMeshProUGUI component used to display dialogue text.
    /// </summary>
    public TextMeshProUGUI dialogueText;

    /// <summary>
    /// The GameObject that contains the dialogue UI.
    /// </summary>
    public GameObject dialogueBox;

    private IDialogueState currentState;
    private Dialogue currentDialogue;

    private void Start()
    {
        dialogueBox.SetActive(false);
        SetState(new IdleDialogueState(this));
    }

    /// <summary>
    /// Starts displaying a new dialogue.
    /// </summary>
    /// <param name="dialogue">The Dialogue object to display.</param>
    public void StartDialogue(Dialogue dialogue)
    {
        currentDialogue = dialogue;
        dialogueBox.SetActive(true);
        SetState(new DisplayingDialogueState(this));
    }

    /// <summary>
    /// Displays the next sentence in the current dialogue.
    /// </summary>
    public void DisplayNextSentence()
    {
        if (currentDialogue.HasNextSentence())
        {
            dialogueText.text = currentDialogue.GetNextSentence();
        }
        else
        {
            SetState(new FinishedDialogueState(this));
        }
    }

    /// <summary>
    /// Ends the current dialogue and hides the dialogue box.
    /// </summary>
    public void EndDialogue()
    {
        dialogueBox.SetActive(false);
        SetState(new IdleDialogueState(this));
    }

    /// <summary>
    /// Sets the current state of the dialogue manager.
    /// </summary>
    /// <param name="newState">The new state to set.</param>
    public void SetState(IDialogueState newState)
    {
        currentState = newState;
        currentState.EnterState();
    }

    private void Update()
    {
        currentState.UpdateState();
    }
}

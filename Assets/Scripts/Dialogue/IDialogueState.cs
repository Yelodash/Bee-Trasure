/// <summary>
/// Interface that defines the required methods for a dialogue state.
/// </summary>
public interface IDialogueState
{
    /// <summary>
    /// Called when the state is entered.
    /// </summary>
    void EnterState();

    /// <summary>
    /// Called every frame to update the state.
    /// </summary>
    void UpdateState();
}

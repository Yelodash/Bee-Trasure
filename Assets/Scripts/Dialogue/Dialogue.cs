using System.Collections.Generic;

/// <summary>
/// Represents the dialogue in the game as a list of sentences.
/// </summary>
[System.Serializable]
public class Dialogue
{
    /// <summary>
    /// List of sentences in the dialogue.
    /// </summary>
    public List<string> sentences;

    private int currentSentenceIndex = 0;

    /// <summary>
    /// Checks if there is a next sentence available.
    /// </summary>
    /// <returns>True if there is another sentence available; otherwise, false.</returns>
    public bool HasNextSentence()
    {
        return currentSentenceIndex < sentences.Count;
    }

    /// <summary>
    /// Retrieves the next sentence in the dialogue.
    /// </summary>
    /// <returns>The next sentence as a string.</returns>
    public string GetNextSentence()
    {
        return sentences[currentSentenceIndex++];
    }
}

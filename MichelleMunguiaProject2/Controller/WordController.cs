using MichelleMunguiaProject2.Data;
using MichelleMunguiaProject2.Model;

namespace MichelleMunguiaProject2.Controller;

/// <summary>
/// controller for managing twisted words game logic
/// </summary>
public class WordController
{
    private readonly LetterRandom _letterBag;
    private readonly Dictionary _validator;
    private readonly HashSet<string> _usedWords;

    /// <summary>
    /// Initializes a new instance of the <see cref="WordController"/> class.
    /// </summary>
    public WordController()
    {
        _letterBag = new LetterRandom();
        _validator = new Dictionary("dictionary.json");
        _usedWords = new HashSet<string>();

        Rounds = new List<Round>();
        StartNewRound();
    }

    /// <summary>
    /// Gets the current letters.
    /// </summary>
    /// <value>
    /// The current letters.
    /// </value>
    public List<char> CurrentLetters { get; private set; }

    /// <summary>
    /// Gets the rounds.
    /// </summary>
    /// <value>
    /// The rounds.
    /// </value>
    public List<Round> Rounds { get; } = [];

    /// <summary>
    /// Gets the current round.
    /// </summary>
    /// <value>
    /// The current round.
    /// </value>
    public Round CurrentRound { get; private set; }

    public void StartNewRound()
    {
        CurrentRound = new Round();
        Rounds.Add(CurrentRound);

        GenerateNewLetters();
    }

    /// <summary>
    /// Generates the new letters.
    /// </summary>
    public void GenerateNewLetters()
    {
        CurrentLetters = _letterBag.GetSevenRandomLetters();
        _usedWords.Clear();
    }

    /// <summary>
    /// Useses the valid letters.
    /// </summary>
    /// <param name="word">The word.</param>
    /// <returns></returns>
    public bool UsesValidLetters(string word)
    {
        var temp = new List<char>(CurrentLetters.Select(c => char.ToLower(c)));

        foreach (var ch in word.ToLower())
        {
            if (!temp.Contains(ch))
                return false;
            temp.Remove(ch);
        }

        return true;
    }

    /// <summary>
    /// Determines whether [is valid dictionary word] [the specified word].
    /// </summary>
    /// <param name="word">The word.</param>
    /// <returns>
    ///   <c>true</c> if [is valid dictionary word] [the specified word]; otherwise, <c>false</c>.
    /// </returns>
    public bool IsValidDictionaryWord(string word)
    {
        return _validator.Contains(word.ToLower());
    }

    /// <summary>
    /// Determines whether [is word used] [the specified word].
    /// </summary>
    /// <param name="word">The word.</param>
    /// <returns>
    ///   <c>true</c> if [is word used] [the specified word]; otherwise, <c>false</c>.
    /// </returns>
    public bool IsWordUsed(string word)
    {
        return _usedWords.Contains(word.ToLower());
    }

    /// <summary>
    /// Marks the word used.
    /// </summary>
    /// <param name="word">The word.</param>
    public void MarkWordUsed(string word)
    {
        _usedWords.Add(word.ToLower());
    }

    /// <summary>
    /// Submits the word.
    /// </summary>
    /// <param name="word">The word.</param>
    /// <param name="elapsedTime">The elapsed time.</param>
    /// <returns></returns>
    public (bool isValid, string message, int points) SubmitWord(string word, TimeSpan elapsedTime)
    {
        if (string.IsNullOrWhiteSpace(word))
        {
            CurrentRound.Attempts.Add(new InvalidAttempt(word, elapsedTime, "Empty input"));
            return (false, "Please enter a word.", 0);
        }

        word = word.Trim().ToLower();

        if (word.Length < 3)
        {
            CurrentRound.Attempts.Add(new InvalidAttempt(word, elapsedTime, "Word must be at least 3 letters"));
            return (false, "Word must be at least 3 letters.", 0);
        }

        if (!UsesValidLetters(word))
        {
            CurrentRound.Attempts.Add(new InvalidAttempt(word, elapsedTime,
                "Word uses invalid letters or repeats a letter"));
            return (false, "Word uses invalid letters or repeats a letter.", 0);
        }

        if (!IsValidDictionaryWord(word))
        {
            CurrentRound.Attempts.Add(new InvalidAttempt(word, elapsedTime, "Word not found in dictionary"));
            return (false, "Word is not in the dictionary.", 0);
        }

        if (IsWordUsed(word))
        {
            CurrentRound.Attempts.Add(new InvalidAttempt(word, elapsedTime, "Word has already been used"));
            return (false, "Word has already been used.", 0);
        }

        MarkWordUsed(word);

        var points = word.Length switch
        {
            3 => 90,
            4 => 160,
            5 => 250,
            6 => 360,
            7 => 490,
            _ => 0
        };

        CurrentRound.Attempts.Add(new ValidAttempt(word, elapsedTime, points));

        return (true, $"Valid word! You earned {points} points.", points);
    }
}
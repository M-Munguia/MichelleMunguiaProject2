namespace MichelleMunguiaProject2.Controller;

/// <summary>
///     class that randomizes letters based on frequency
/// </summary>
public class LetterRandom
{
    private readonly List<char> _bag;
    private readonly Random _rando;


    /// <summary>
    ///     Initializes a new instance of the <see cref="LetterRandom" /> class.
    /// </summary>
    public LetterRandom()
    {
        _bag = new List<char>();
        _rando = new Random();
        BuildBag();
    }

    /// <summary>
    ///     Builds the bag.
    /// </summary>
    private void BuildBag()
    {
        void AddLetters(char letter, int count)
        {
            for (var i = 0; i < count; i++) _bag.Add(letter);
        }

        AddLetters('e', 11);
        AddLetters('t', 9);
        AddLetters('o', 8);

        AddLetters('a', 6);
        AddLetters('i', 6);
        AddLetters('n', 6);
        AddLetters('s', 6);

        AddLetters('h', 5);
        AddLetters('r', 5);

        AddLetters('l', 4);

        AddLetters('d', 3);
        AddLetters('u', 3);
        AddLetters('w', 3);
        AddLetters('y', 3);

        AddLetters('b', 2);
        AddLetters('c', 2);
        AddLetters('f', 2);
        AddLetters('g', 2);
        AddLetters('m', 2);
        AddLetters('p', 2);
        AddLetters('v', 2);

        AddLetters('j', 1);
        AddLetters('k', 1);
        AddLetters('q', 1);
        AddLetters('x', 1);
        AddLetters('z', 1);
    }

    /// <summary>
    ///     Gets the seven random letters.
    /// </summary>
    /// <returns></returns>
    public List<char> GetSevenRandomLetters()
    {
        var result = new List<char>();

        for (var i = 0; i < 7; i++)
        {
            var index = _rando.Next(_bag.Count);
            result.Add(_bag[index]);
        }

        return result;
    }
}
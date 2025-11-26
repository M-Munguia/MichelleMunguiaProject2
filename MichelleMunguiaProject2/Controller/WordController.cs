using MichelleMunguiaProject2.Data;
using MichelleMunguiaProject2.Model;
using System.ComponentModel.DataAnnotations;

namespace MichelleMunguiaProject2.Controller
{
    public class WordController
    {
        private readonly LetterRandom letterBag;
        private readonly Dictionary validator;

        public List<char> CurrentLetters { get; private set; }
        private HashSet<string> usedWords;

        public WordController()
        {
            letterBag = new LetterRandom();
            validator = new Dictionary("dictionary.json");
            usedWords = new HashSet<string>();

            GenerateNewLetters();
        }

        public void GenerateNewLetters()
        {
            CurrentLetters = letterBag.GetSevenRandomLetters();
            usedWords.Clear();
        }

        // Check if word uses only the available letters and each once
        public bool UsesValidLetters(string word)
        {
            var temp = new List<char>(CurrentLetters.Select(c => char.ToLower(c)));

            foreach (char ch in word.ToLower())
            {
                if (!temp.Contains(ch))
                    return false;

                temp.Remove(ch);
            }

            return true;
        }

        // Main logic for validating & scoring a word
        //public (bool isValid, int points, string message) SubmitWord(string word)
        //{
        //    word = word.Trim().ToLower();

        //    if (word.Length < 3)
        //      return (false, 0, "Word must be at least 3 letters.");

        //if (!UsesValidLetters(word))
        //return (false, 0, "Word uses letters not available.");

        //if (usedWords.Contains(word))
        //  return (false, 0, "Word already submitted.");

        //if (!validator.IsValid(word))
        //    return (false, 0, "Word not found in dictionary.");

        // Calculate points
        //int points = ScoreCalculator.GetPoints(word);
        //usedWords.Add(word);

        //  return (true, points, $"Valid word! +{points} points.");
        //}
    }
}
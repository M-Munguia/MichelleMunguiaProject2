using System.Text.Json;

namespace MichelleMunguiaProject2.Data
{
    /// <summary>
    /// loads and validates words from a dictionary file
    /// </summary>
    public class Dictionary
    {
        private readonly HashSet<string> _words;

        /// <summary>
        /// Initializes a new instance of the <see cref="Dictionary"/> class.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        /// <exception cref="System.IO.FileNotFoundException">Dictionary file not found: {path}</exception>
        public Dictionary(string fileName)
        {
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", fileName);

                if (!File.Exists(path))
                    throw new FileNotFoundException($"Dictionary file not found: {path}");

                string json = File.ReadAllText(path);

                var data = JsonSerializer.Deserialize<List<LetterWords>>(json);

                _words = new HashSet<string>();
                if (data != null && data.Count > 0)
                {
                    foreach (var w in data[0].words)
                        _words.Add(w.ToLower());
                }
            }
        }

        /// <summary>
        /// Determines whether this instance contains the object.
        /// </summary>
        /// <param name="word">The word.</param>
        /// <returns>
        ///   <c>true</c> if [contains] [the specified word]; otherwise, <c>false</c>.
        /// </returns>
        public bool Contains(string word)
            {
                return _words.Contains(word.ToLower());
            }
    }
}

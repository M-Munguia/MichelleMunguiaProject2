namespace MichelleMunguiaProject2.Model
{
    /// <summary>
    /// parent class for the data structure of an attempt
    /// </summary>
    public abstract class Attempt
    {
        /// <summary>
        /// Gets the word.
        /// </summary>
        /// <value>
        /// The word.
        /// </value>
        public string Word { get; }
        /// <summary>
        /// Gets the game time.
        /// </summary>
        /// <value>
        /// The game time.
        /// </value>
        public TimeSpan GameTime { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Attempt"/> class.
        /// </summary>
        /// <param name="word">The word.</param>
        /// <param name="gameTime">The game time.</param>
        protected Attempt(string word, TimeSpan gameTime)
        {
            Word = word;
            GameTime = gameTime;
        }
    }
}
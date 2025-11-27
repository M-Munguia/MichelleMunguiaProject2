namespace MichelleMunguiaProject2.Model
{
    /// <summary>
    /// class for a valid attempt
    /// </summary>
    /// <seealso cref="MichelleMunguiaProject2.Model.Attempt" />
    public class ValidAttempt : Attempt
    {
        /// <summary>
        /// Gets the points.
        /// </summary>
        /// <value>
        /// The points.
        /// </value>
        public int Points { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidAttempt"/> class.
        /// </summary>
        /// <param name="word">The word.</param>
        /// <param name="gameTime">The game time.</param>
        /// <param name="points">The points.</param>
        public ValidAttempt(string word, TimeSpan gameTime, int points)
            : base(word, gameTime)
        {
            Points = points;
        }
    }
}

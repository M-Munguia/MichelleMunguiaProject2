namespace MichelleMunguiaProject2.Model
{
    /// <summary>
    /// class that stores an invalid attempt
    /// </summary>
    /// <seealso cref="MichelleMunguiaProject2.Model.Attempt" />
    public class InvalidAttempt : Attempt
    {
        /// <summary>
        /// Gets the reason.
        /// </summary>
        /// <value>
        /// The reason.
        /// </value>
        public string Reason { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidAttempt"/> class.
        /// </summary>
        /// <param name="word">The word.</param>
        /// <param name="gameTime">The game time.</param>
        /// <param name="reason">The reason.</param>
        public InvalidAttempt(string word, TimeSpan gameTime, string reason)
            : base(word, gameTime)
        {
            Reason = reason;
        }
    }
}

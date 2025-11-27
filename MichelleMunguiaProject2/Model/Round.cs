namespace MichelleMunguiaProject2.Model
{
    /// <summary>
    /// Class for the data structure of the current round
    /// </summary>
    public class Round
    {
        /// <summary>
        /// Gets the attempts.
        /// </summary>
        /// <value>
        /// The attempts.
        /// </value>
        public List<Attempt> Attempts { get; private set; } = new List<Attempt>();

    }
}

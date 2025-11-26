namespace MichelleMunguiaProject2.Model
{
    public class LetterRandom
    {
        private List<char> _bag;
        private Random _rando;

        public LetterRandom()
        {
            _bag = new List<char>();
            _rando = new Random();
            BuildBag();
        }

        private void BuildBag()
        {
            // local helper to add repeated letters
            void AddLetters(char letter, int count)
            {
                for (int i = 0; i < count; i++)
                {
                    _bag.Add(letter);
                }
            }

            // Frequencies provided in the assignment
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

        public List<char> GetSevenRandomLetters()
        {
            List<char> result = new List<char>();

            for (int i = 0; i < 7; i++)
            {
                int index = _rando.Next(_bag.Count);
                result.Add(_bag[index]);
            }

            return result;
        }
    }
}


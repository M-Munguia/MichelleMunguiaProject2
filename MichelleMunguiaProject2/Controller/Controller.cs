using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MichelleMunguiaProject2.Model
{
    public class Controller
    {
        public List<char> GenerateSevenLetters()
        {
            var rng = new Random();
            var bag = new List<char>();

            void Add(char letter, int frequency)
            {
                for (var i = 0; i < frequency; i++)
                    bag.Add(letter);
            }

            // Add letters according to frequencies
            Add('e', 11);
            Add('t', 9);
            Add('o', 8);

            foreach (var c in new[] { 'a', 'i', 'n', 's' }) Add(c, 6);
            foreach (var c in new[] { 'h', 'r' }) Add(c, 5);

            Add('l', 4);

            foreach (var c in new[] { 'd', 'u', 'w', 'y' }) Add(c, 3);
            foreach (var c in new[] { 'b', 'c', 'f', 'g', 'm', 'p', 'v' }) Add(c, 2);
            foreach (var c in new[] { 'j', 'k', 'q', 'x', 'z' }) Add(c, 1);

            // Draw 7 random letters
            var result = new List<char>();

            for (var i = 0; i < 7; i++)
            {
                var index = rng.Next(bag.Count);
                result.Add(bag[index]);
                bag.RemoveAt(index); // prevent duplicate draw from the same instance
            }

            return result;
        }
    }
}

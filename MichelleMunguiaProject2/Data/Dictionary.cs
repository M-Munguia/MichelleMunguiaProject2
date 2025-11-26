using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MichelleMunguiaProject2.Data
{
    public class Dictionary
    {
        private HashSet<string> words;

        public Dictionary(string fileName)
        {
            // Build the path to the output folder
            string path = Path.Combine(Directory.GetCurrentDirectory(), fileName);

            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                words = JsonSerializer.Deserialize<HashSet<string>>(json) ?? new HashSet<string>();
            }
            else
            {
                // fallback if file is missing
                words = new HashSet<string>();
            }
        }

        public bool Contains(string word)
            {
                return words.Contains(word.ToLower());
            }
    }
}

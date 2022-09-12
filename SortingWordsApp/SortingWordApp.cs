using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingWordsApp
{
    public class SortingWordApp
    {
        public List<char> Sort(string sentence)
        {
            string[] words = sentence.Split(null);
            List<char> endChars = new List<char>();

            foreach (string s in words)
            {
                endChars.Add(s[s.Length - 1]);
            }
            return endChars;
        }
    }
}

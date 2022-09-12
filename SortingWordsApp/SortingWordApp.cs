using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingWordsApp
{
    public class SortingWordApp
    {
        public string[] Sort(string sentence)
        {
            string[] words = sentence.Split(null);
            return words;
        }
    }
}

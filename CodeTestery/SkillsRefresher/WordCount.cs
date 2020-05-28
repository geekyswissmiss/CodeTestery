using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SkillsRefresher
{
    public class WordCount
    {
        string Sentence;
        string[] Words;

        public WordCount(string sentence)
        {
            Sentence = sentence;
            Words = sentence.Split(' ');
        }

        public void OutputWordCount()
        {
            try
            {
                //grab words, grouped by and ordered by length
                var query = Words.
                    GroupBy(w => w.Length, w => w.ToUpper()).
                    Select(g => new { Length = g.Key, Words = g }).
                    OrderBy(o => o.Length);

                //cout them
                foreach (var obj in query)
                {
                    Console.WriteLine("Words of length {0}:", obj.Length);
                    foreach (string word in obj.Words)
                        Console.WriteLine(word);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

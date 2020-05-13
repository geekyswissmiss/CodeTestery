using System;
using System.Collections.Generic;

namespace WordFinder
{
    public static class WordFinder
    {
        //counts the number of times word can be found in puzzle
        //iterates letter-by-letter, not most efficient
        public static int WordCount(String puzzle, String word)
        {
            int count = 0;
            try
            {
                //words can only be found in strings of words.length or longer
                while (puzzle.Length >= word.Length)
                {
                    foreach (char letter in word.ToCharArray())
                    {
                        if (puzzle.Contains(letter))
                        {
                            int letterIndex = puzzle.IndexOf(letter);
                            puzzle = puzzle.Remove(letterIndex, 1);
                        }
                        else
                        {
                            Exception ex = new Exception(word + " not found in " + puzzle);
                            throw ex;
                        }
                    }
                    count++;
                }
            }
            catch (Exception ex)
            {
                //meh
            }
            return count;
        }
    }
}

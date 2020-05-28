using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Playground
{
    public class WordFinder2
    {
        //static void Main(string[] args)
        //{
        //    string jumble = "BALLOONBALLOONABCHDKNOGNSLSJCJBH";
        //    WordFinder2 wf = new WordFinder2();
        //    int count = wf.CountBALLOON(jumble);
        //}

        //counts the number of times word can be found in puzzle
        //iterates letter-by-letter
        public int CountBALLOON(string puzzle)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int count = 0;
            string word = "BALLOON";

            try
            {
                //parse S for word as long as it is possible for S to contain word
                while (puzzle.Length >= word.Length)
                {
                    //sort alphabetically, use regular expression
                    //BALLOON=>ABLLNOO=>AB*LL*NOO*
                    string regexPattern = @"^A+B+[\w]*(LL)+[\w]*N+(OO)+[\w]*";
                    Regex regex = new Regex(regexPattern);
                    string sortedPuzzle = String.Concat(puzzle.OrderBy(c => c));
                    //if there's a match, remove one instance of the letters
                    if (regex.IsMatch(sortedPuzzle))
                    {
                        count++;
                        foreach (char letter in word.ToCharArray())
                        {
                            //found the letter, remove it
                            int letterIndex = puzzle.IndexOf(letter);
                            puzzle = puzzle.Remove(letterIndex, 1);
                        }
                    }
                    else
                    {
                        //not found, get out of here
                        Exception ex = new Exception(word + " not found in " + puzzle);
                        throw ex;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return count;
        }
        public int solution1(string S)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int count = 0;
            string word = "BALLOON";

            try
            {
                //parse S for word as long as it is possible for S to contain word
                while (S.Length >= word.Length)
                {
                    //look for each letter in word (BALLOON)
                    foreach (char letter in word.ToCharArray())
                    {
                        if (S.Contains(letter.ToString()))
                        {
                            //found the letter, remove it
                            int letterIndex = S.IndexOf(letter);
                            S = S.Remove(letterIndex, 1);
                        }
                        else
                        {
                            //letter not found, get out of here
                            Exception ex = new Exception(word + " not found in " + S);
                            throw ex;
                        }
                    }
                    //found the whole word, increase count
                    count++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return count;
        }
    }
}

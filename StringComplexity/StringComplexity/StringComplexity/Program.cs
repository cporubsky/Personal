using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Corey Porubsky
/// 05/02/2016
/// Calculates string complexity
/// Extra credit for Cis527
/// </summary>
namespace StringComplexity
{
    class Program
    {
        /// <summary>
        /// stores letters and occurrences respectively
        /// </summary>
        public static Dictionary<char, int> _dictionary = new Dictionary<char, int>();

        /// <summary>
        /// StringBuilder to store result
        /// </summary>
        public static StringBuilder _sb = new StringBuilder();

        /// <summary>
        /// main program
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //reads word, converts to lowercase for consistency
            //adds to StringBuilder
            _sb.Append(Console.ReadLine().ToLower());

            //if over 100 letters, or
            //if StringBuilder is empty -> exit program
            if (_sb.Length > 101 || _sb.Length == 0) return;

            //processes string to count occurrences
            ProcessString(_sb, _dictionary);

            //computes times eraser is needed
            //and prints result
            ComputeEraser(_sb, _dictionary);
             
            //holds cmd window open
            Console.ReadLine();
        }

        /// <summary>
        /// processes string, and counts letter occurances
        /// </summary>
        /// <param name="sb">StringBuilder to parse</param>
        /// <param name="d">Dictionary used to store key, value pairs</param>
        public static void ProcessString(StringBuilder sb, Dictionary<char,int> d)
        {
            //convert StringBuilder 
            //to string for processing
            string s = sb.ToString();
            
            //try to process
            try
            {
                //enumerates through chars in str
                foreach (char c in s)
                {
                    //if c isn't a letter, don't count
                    if (!char.IsLetter(c)) continue;

                    //if the key exists, increment value
                    if (d.ContainsKey(c)) d[c]++;

                    //if key doesn't exit, this is the first occurence
                    else d[c] = 1;
                }
            }
            //catch exception
            //write to console
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }   
        }

        /// <summary>
        /// computes number of times eraser is needed
        /// and prints the results
        /// </summary>
        /// <param name="sb">StringBuilder to store result</param>
        /// <param name="d">Dictionary used to store key, value pairs</param>
        public static void ComputeEraser(StringBuilder sb, Dictionary<char, int> d)
        {
            //minimum times eraser must be used
            //complexity is dictionary size, d.Count
            int magicNumber = d.Count - 2; //4

            //clear console
            Console.Clear();

            //if complexity is less than zero, 
            //then eraser doesn't have to be used
            if (magicNumber < 0) Console.Write(sb.Append(" 0").ToString()); //consider checking for -1 on magic number, and check that complexity is > 0

            //complexity is greater than 1, print minimum times eraser is needed
            else Console.Write(sb.Append(" " + magicNumber.ToString()));
        }
    }
}

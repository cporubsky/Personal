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
            _sb.Append(Console.ReadLine().ToLower()); //reads word, converts to lowercase for consistency, adds to StringBuilder
            
            if (_sb.Length > 101 || _sb.Length < 1) return; //if over 100 letters, or if StringBuilder is empty -> exit program

            ProcessString(_sb, _dictionary); //processes string to count occurrences 
            ComputeEraser(_sb, _dictionary); //computes times eraser is needed and prints result
            Console.ReadLine(); //holds cmd window open
        }

        /// <summary>
        /// processes string, and counts letter occurances
        /// </summary>
        /// <param name="sb">StringBuilder to parse</param>
        /// <param name="d">Dictionary used to store key, value pairs</param>
        public static void ProcessString(StringBuilder sb, Dictionary<char,int> d)
        {
            string s = sb.ToString(); //convert StringBuilder to string for processing

            try //try to process
            {
                
                foreach (char c in s) //enumerates through chars in str
                {            
                    if (!char.IsLetter(c)) continue; //if c isn't a letter, don't count
                    if (d.ContainsKey(c)) d[c]++; //if the key exists, increment value 
                    else d[c] = 1; //if key doesn't exit, this is the first occurence
                }
            }
            catch(Exception e) //catch exception
            {
                Console.WriteLine(e.ToString()); //write to console
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
            int magicNumber = d.Count - 2; //minimum times eraser must be used, complexity is dictionary size -> d.Count

            Console.Clear(); //clear console

            if (magicNumber < 0) Console.Write(sb.Append(" 0").ToString()); //if complexity is less than zero, then eraser doesn't have to be used 
            else Console.Write(sb.Append(" " + magicNumber.ToString())); //complexity is greater than 1, print minimum times eraser is needed
        }
    }
}

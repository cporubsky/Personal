using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        
        static void Main(string[] args)
        {
            //stores letters and occurrences respectively
            Dictionary<char, int> _dictionary = new Dictionary<char, int>();
            
            //ask user for a word
            Console.Write("Enter a word: "); 

            //reads word and converts to lowercase for consistency
            String str = Console.ReadLine().ToLower();

            //if over 100 letters exit program
            if (str.Length < 101) return;

            //enumerates through chars in str
            foreach(char c in str)
            {   
                //if the key exists, increment value
                if (_dictionary.ContainsKey(c)) _dictionary[c]++;
                //if key doesn't exit, this is the first occurence
                else _dictionary[c] = 1;
            }

            //for testing
            foreach (var pair in _dictionary)
            {
                Console.WriteLine(pair.Key + " " + pair.Value);
            }
            
            //string complexity
            int complexity = _dictionary.Count;

            //minimum times eraser must be used
            int magicNumber = _dictionary.Count - 2; //4

            //if complexity is 1, then eraser doesn't have to be used
            if (complexity == 1) Console.WriteLine("Minimum times to use eraser: " + 0); //consider checking for -1 on magic number, and check that complexity is > 0

            //coplexity is greater than 1, print minimum times eraser is needed
            else
            {
                Console.WriteLine("String complexity is: " + complexity); //6      
                Console.WriteLine("Minimum times to use eraser: " + magicNumber);
            }
            
            //holds cmd window open
            Console.ReadLine();

            
        }

        
    }
}

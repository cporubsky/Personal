using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringComplexity
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Dictionary<char, int> _dictionary = new Dictionary<char, int>();
            
            Console.Write("Enter a string: ");
            String str = Console.ReadLine().ToLower();

            foreach(char c in str)
            {
                if (_dictionary.ContainsKey(c)) _dictionary[c]++;
                else _dictionary[c] = 1;
            }
            foreach (var pair in _dictionary)
            {
                Console.WriteLine(pair.Key + " " + pair.Value);
            }
            int complexity = _dictionary.Count;
            int magicNumber = _dictionary.Count - 2; //4
            if (complexity == 1) Console.WriteLine("Minimum times to use eraser: " + 0);
            else
            {
                Console.WriteLine("String complexity is: " + complexity); //6      
                Console.WriteLine("Minimum times to use eraser: " + magicNumber);
            }
            
            
            Console.ReadLine();

            
        }

        
    }
}

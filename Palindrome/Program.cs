using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaration and Initialization
            string Word, reversedWord = "";
            Console.Write(" Enter a Word: ");
            Word = Console.ReadLine();
            //String Reverse  
            for (int i = Word.Length - 1; i >= 0; i--) 
            {
                reversedWord += Word[i].ToString();
            }
            // Checking whether string is palindrome or not  
            if (reversedWord == Word)
            {
                
                Console.WriteLine("A Word is Palindrome");
            }
            else
            {
                Console.WriteLine("A Word is not Palindrome");
            }
            Console.ReadLine();

        }
    }
}

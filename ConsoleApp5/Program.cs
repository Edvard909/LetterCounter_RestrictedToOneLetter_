using System.ComponentModel;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a word: ");
            string word = Console.ReadLine();
            char a = 'a';   //Counting letter a
            
            int counter = 0;
            
            foreach (char letterA in word) 
            {
                if (letterA == a) 
                { 
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}



    
//}
//-Write a program that calculates how many times each letter present in user input.
//Example:
// -Input: "This is input"
//- Output: 
//   t - 2
//   h - 1
//   i - 3
//   s - 2
//   n - 1
//   p - 1
//   u - 1

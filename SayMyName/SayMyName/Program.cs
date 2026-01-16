/*Luke Kloer
Rcet 2265
Semester Spring 2026
RCET 2265 - Programming in C#
SayMyName Program
GitHub URL:
https://github.com/lukekloer55-prog/CLassExamples/tree/main/SayMyName*/

using System.Diagnostics;

namespace SayMyName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name below.");
            string Name = Console.ReadLine();
            Console.WriteLine($"Hello {Name} it's nice to see you today!");
        }
    }
}
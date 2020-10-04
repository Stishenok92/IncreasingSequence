using System;
using System.ComponentModel.DataAnnotations;
using static IncreasingSequenceLibrary.IncreasingSequence;

namespace IncreasingSequenceProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task #02. Increasing sequence\n");
            Console.Write("Enter integer number: ");

            try
            {
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine("Is increasing sequence: " + CheckIncreasingSequenceDigits(number));
                Console.WriteLine("Is descending sequence: " + CheckDescendingSequenceDigits(number));
            }
            catch (ValidationException)
            {
                Console.WriteLine("Error: ValidationException");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: FormatException");
            }
        }
    }
}
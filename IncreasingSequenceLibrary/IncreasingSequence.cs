using System;
using System.ComponentModel.DataAnnotations;

namespace IncreasingSequenceLibrary
{
    public class IncreasingSequence
    {
        public const int MINIMUM_TWO_DIGIT_NUMBER = 10;

        public static bool CheckSequence(int number)
        {
            return Math.Abs(number) >= MINIMUM_TWO_DIGIT_NUMBER;
        }

        public static bool CheckIncreasingSequenceDigits(int number)
        {
            if (!CheckSequence(number))
            {
                throw new ValidationException();
            }

            bool flag = true;

            int current = number % 10;
            number /= 10;
            
            while (number != 0)
            {
                if (number % 10 < current)
                {
                    current = number % 10;
                    number /= 10;
                }
                else
                {
                    flag = false;
                    break;
                }
            }

            return flag;
        }

        public static bool CheckDescendingSequenceDigits(int number)
        {
            if (!CheckSequence(number))
            {
                throw new ValidationException();
            }

            bool flag = true;

            int current = number % 10;
            number /= 10;
            
            while (number != 0)
            {
                if (number % 10 > current)
                {
                    current = number % 10;
                    number /= 10;
                }
                else
                {
                    flag = false;
                    break;
                }
            }

            return flag;
        }
    }
}
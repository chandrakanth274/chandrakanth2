using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloatAddition
{
    class ClassFloatAddition
    { 

        /// <summary>
        /// Method to convert a number to its binary form.
        /// </summary>
        /// <param name="number"> It is the number given by user. </param>
        /// <returns> It returns an array which contains the binary form of number. </returns>

        public int[] DecimaToBinary(float number)
        {
            int integer, remainder, firstTemporary, incriment = 1, secondTemporary = 0;
            float fraction;
            integer = (int)number;
            firstTemporary = integer;
            int[] array = new int[30];
            while (firstTemporary > 0)
            {
                remainder = firstTemporary % 2;
                firstTemporary = firstTemporary / 2;
                array[incriment] = remainder;
                incriment++;
            }

            array[0] = incriment;
            fraction = number - integer;
            for (int index = 22; index < 30; index++)
            {
                secondTemporary = (int)(2 * fraction);
                fraction = (2 * fraction) - secondTemporary;
                array[index] = secondTemporary;
            }
            return array;
        }

        /// <summary>
        /// Method to add two binary numbers.
        /// </summary>
        /// <param name="firstArray"> Binary form of first number. </param>
        /// <param name="secondArray"> Binary form of second number. </param>
        /// <returns> Returns an array having sum of the two binary numbers. </returns>

        public int[] BinaryAddition(int[] firstArray, int[] secondArray)
        {
            int[] thirdArray = new int[30];

            int range, rangeFirstnumber, rangeSecondnumber;
            rangeFirstnumber = firstArray[0];
            rangeSecondnumber = secondArray[0];
            if (rangeFirstnumber > rangeSecondnumber)
            {
                range = rangeFirstnumber;
            }
            else
            {
                range = rangeSecondnumber;
            }

            // Adding fractional parts of two binary numbers.

            int firstIncriment = range + 9;
            int firstCounter = 0, sum = 0;
            for (int index = 29; index >= 22; index--)
            {
                sum = firstArray[index] + secondArray[index] + firstCounter;
                if (sum == 0)
                {
                    thirdArray[firstIncriment] = 0;
                    firstCounter = 0;
                }
                else if (sum == 1)
                {
                    thirdArray[firstIncriment] = 1;
                    firstCounter = 0;
                }
                else if (sum == 2)
                {
                    thirdArray[firstIncriment] = 0;
                    firstCounter = 1;
                }
                else
                {
                    thirdArray[firstIncriment] = 1;
                    firstCounter = 1;
                }
                firstIncriment--;
            }

            // Adding integer parts of two binary numbers.

            int secondIncriment = range + 1;
            int secondCounter = 0;
            for (int index = 1; index <= range; index++)
            {
                sum = firstArray[index] + secondArray[index] + secondCounter + firstCounter;
                if (sum == 0)
                {
                    thirdArray[secondIncriment] = 0;
                    secondCounter = 0;
                }
                else if (sum == 1)
                {
                    thirdArray[secondIncriment] = 1;
                    secondCounter = 0;
                }
                else if (sum == 2)
                {
                    thirdArray[secondIncriment] = 0;
                    secondCounter = 1;
                }
                else
                {
                    thirdArray[secondIncriment] = 1;
                    secondCounter = 1;
                }
                secondIncriment--;
                firstCounter = 0;
            }
            thirdArray[1] = secondCounter;
            thirdArray[0] = range;

            return thirdArray;
        }

        /// <summary>
        /// Method to convert a binary number into its decimal form.
        /// </summary>
        /// <param name="array"> It is the sum of two binary numbers. </param>
        /// <returns> Returns a floating decimal of binary number in array. </returns>

        public float BinaryToDecimal(int[] array)
        {
            float integer = 0, fraction = 0;
            int range = array[0];

            ClassFloatAddition obj = new ClassFloatAddition();

            for (int index = (range + 1); index > 0; index--)
            {
                float power = PowerOfTwo((range + 1) - index);
                integer = (array[index] * power) + integer;
            }
            for (int index = 1; index <= 8; index++)
            {
                float power = PowerOfTwo(index);
                power = 1 / power;
                fraction = array[index + range + 1] * power + fraction;
            }
            return integer + fraction;
        }

        /// <summary>
        /// Method to calculate the number power of 2.
        /// </summary>
        /// <param name="number"> It is the number whose power of 2 is required. </param>
        /// <returns> Returns number power of 2. </returns>

        public float PowerOfTwo(int number)
        {
            float power = 1;
            for (int index = 0; index < number; index++)
            {
                power = 2 * power;
            }
            return power;
        }

        /// <summary>
        /// Method to display numbers, their binary forms, sum of binary forms and decimal form of sum of binary forms.
        /// </summary>
        /// <param name="firstNumber"> Number entered by user. </param>
        /// <param name="secondNumber"> Number entered by user. </param>
        /// <param name="firstArray"> Binary form of first number. </param>
        /// <param name="secondArray"> Binary form of second number. </param>
        /// <param name="thirdArray"> Sum of two binary forms. </param>
        /// <param name="result"> Decimal form of sum of two binary forms. </param>

        public void Display(float firstNumber, float secondNumber, int[] firstArray, int[] secondArray, int[] thirdArray, float result)
        {
            int range = thirdArray[0];

            // To print the binary forms of two numbers.

            Console.Write("Binary form of {0} : ", firstNumber);
            for (int index = range; index > 0; index--)
            {
                Console.Write(firstArray[index]);
            }
            Console.Write(".");
            for (int index = 22; index < 30; index++)
            {
                Console.Write(firstArray[index]);
            }
            Console.WriteLine(" ");
            Console.Write("Binary form of {0} : ", secondNumber);
            for (int index = range; index > 0; index--)
            {
                Console.Write(secondArray[index]);
            }
            Console.Write(".");
            for (int index = 22; index < 30; index++)
            {
                Console.Write(secondArray[index]);
            }
            Console.WriteLine(" ");

            // To print the binary sum of two numbers.

            Console.WriteLine(" ");
            Console.Write("Sum of Binary forms is : ");
            for (int index = 1; index <= (range + 1); index++)
            {
                Console.Write(thirdArray[index]);
            }
            Console.Write(".");
            for (int index = (range + 2); index < (range + 10); index++)
            {
                Console.Write(thirdArray[index]);
            }
            Console.WriteLine(" ");
            Console.WriteLine("Sum of numbers is : {0}", result);
        }
    }
}
using System;
namespace FloatAddition
{
    class Program
    {

        // Method that takes a number and returns Binary form of integral part of the number.

        public static int[] Integer(float number)
        {
            int firstInteger, firstRemainder, firstTemp, firstIncriment = 1;
            firstInteger = (int)number;
            firstTemp = firstInteger;
            int[] firstArray = new int[30];
            while (firstTemp > 0)
            {
                firstRemainder = firstTemp % 2;
                firstTemp = firstTemp / 2;
                firstArray[firstIncriment] = firstRemainder;
                firstIncriment++;
            }
            firstArray[0] = firstIncriment;
            return firstArray;
        }

        // Method that takes a number and returns Binary form of fractional part of the number.

        public static int[] Fraction(float number)
        {
            float firstFraction;
            int firstInteger, firstTemp, secondTemp = 0, secondIncriment = 1;
            firstInteger = (int)number;
            firstTemp = firstInteger;
            int[] secondArray = new int[30];
            firstFraction = number - firstInteger;
            for (int index = 1; index < 9; index++)
            {
                secondTemp = (int)(2 * firstFraction);
                firstFraction = (2 * firstFraction) - secondTemp;
                secondArray[secondIncriment] = secondTemp;
                secondIncriment++;
            }
            return secondArray;
        }

        // Method that adds the Binary form of two numbers and converts the sum to Decimal form.
        public static void BinaryAddition(float firstNumber, float secondNumber)
        {
            int[] firstArray = new int[30];
            int[] secondArray = new int[30];
            int[] thirdArray = new int[30];
            int[] fourthArray = new int[30];
            firstArray = Integer(firstNumber);
            secondArray = Fraction(firstNumber);
            thirdArray = Integer(secondNumber);
            fourthArray = Fraction(secondNumber);
            int range, rangeFirstnumber, rangeSecondnumber;
            rangeFirstnumber = firstArray[0];
            rangeSecondnumber = thirdArray[0];
            if (rangeFirstnumber > rangeSecondnumber)
            {
                range = rangeFirstnumber;
            }
            else
            {
                range = rangeSecondnumber;
            }

            // To print the binary forms of two numbers.

            Console.Write("Binary form of first   number is : ");
            for (int index = range; index > 0; index--)
            {
                Console.Write(firstArray[index]);
            }
            Console.Write(".");
            for (int index = 1; index <= 8; index++)
            {
                Console.Write(secondArray[index]);
            }
            Console.WriteLine(" ");
            Console.Write("Binary form of second  number is : ");
            for (int index = range; index > 0; index--)
            {
                Console.Write(thirdArray[index]);
            }
            Console.Write(".");
            for (int index = 1; index <= 8; index++)
            {
                Console.Write(fourthArray[index]);
            }

            // Adding fractional parts of two binary numbers.

            int fifthIncriment = range + 9;
            int[] fifthArray = new int[40];
            Console.WriteLine(" ");
            int firstCounter = 0, sum = 0;
            for (int index = 8; index > 0; index--)
            {
                sum = secondArray[index] + fourthArray[index] + firstCounter;
                if (sum == 0)
                {
                    fifthArray[fifthIncriment] = 0;
                    firstCounter = 0;
                }
                else if (sum == 1)
                {
                    fifthArray[fifthIncriment] = 1;
                    firstCounter = 0;
                }
                else if (sum == 2)
                {
                    fifthArray[fifthIncriment] = 0;
                    firstCounter = 1;
                }
                else
                {
                    fifthArray[fifthIncriment] = 1;
                    firstCounter = 1;
                }
                fifthIncriment--;
            }

            // Adding integer parts of two binary numbers.

            int sixthIncriment = range;
            int secondCounter = 0;
            for (int index = 1; index <= range; index++)
            {
                sum = firstArray[index] + thirdArray[index] + secondCounter + firstCounter;
                if (sum == 0)
                {
                    fifthArray[sixthIncriment] = 0;
                    secondCounter = 0;
                }
                else if (sum == 1)
                {
                    fifthArray[sixthIncriment] = 1;
                    secondCounter = 0;
                }
                else if (sum == 2)
                {
                    fifthArray[sixthIncriment] = 0;
                    secondCounter = 1;
                }
                else
                {
                    fifthArray[sixthIncriment] = 1;
                    secondCounter = 1;
                }
                sixthIncriment--;
                firstCounter = 0;
            }
            fifthArray[0] = secondCounter;

            // Converting the sum of Binary numbers into Decimal number.

            float thirdInteger = 0, thirdFraction = 0;
            for (int index = range; index >= 0; index--)
            {
                float power = PowerOfTwo(range - index);
                thirdInteger = (fifthArray[index] * power) + thirdInteger;
            }
            for (int index = 1; index <= 8; index++)
            {
                float power = PowerOfTwo(index);
                power = 1 / power;
                thirdFraction = fifthArray[index + range + 1] * power + thirdFraction;
            }

            // To print the sum of Binary numbers.

            Console.WriteLine(" ");
            Console.Write("Binary sum  of given numbers is : ");
            for (int index = 0; index <= range; index++)
            {
                Console.Write(fifthArray[index]);
            }
            Console.Write(".");
            for (int index = (range + 2); index <= (range + 9); index++)
            {
                Console.Write(fifthArray[index]);
            }
            Console.WriteLine(" ");

            // To print the Decimal number obtained after addition.

            Console.WriteLine(thirdInteger + thirdFraction);
        }

        // Method to calculate 2th power of any number.

        public static float PowerOfTwo(int number)
        {
            float power = 1;
            for (int index = 0; index < number; index++)
            {
                power = 2 * power;
            }
            return power;
        }

        // Main method.

        static void Main(string[] args)
        {
            Console.WriteLine("Enter two Numbers:");
            float firstNumber = float.Parse(Console.ReadLine());
            float secondNumber = float.Parse(Console.ReadLine());
            BinaryAddition(firstNumber, secondNumber);
            Console.ReadKey();
        }
    }
}
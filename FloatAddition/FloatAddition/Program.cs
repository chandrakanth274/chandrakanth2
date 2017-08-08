using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloatAddition
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter two Numbers:");
            float firstNumber = float.Parse(Console.ReadLine());
            float secondNumber = float.Parse(Console.ReadLine());
            float result;

            int[] firstArray = new int[30];
            int[] secondArray = new int[30];
            int[] thirdArray = new int[30];

            ClassFloatAddition obj1 = new ClassFloatAddition();

            firstArray = obj1.DecimaToBinary(firstNumber);
            secondArray = obj1.DecimaToBinary(secondNumber);

            thirdArray = obj1.BinaryAddition(firstArray, secondArray);

            result = obj1.BinaryToDecimal(thirdArray);

            obj1.Display(firstNumber, secondNumber, firstArray, secondArray, thirdArray, result);

            Console.ReadKey();
        }
    }
}
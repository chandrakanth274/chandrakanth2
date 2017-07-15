using System;
class DecimalToBinary
{
    static void Main()
    {
        //first number

        float a, c;
        Console.WriteLine("Enter two Numbers:");
        a = float.Parse(Console.ReadLine());
        int b, rem, num, d = 0, k = 0, l = 0;
        b = (int)a;
        num = b;
        int[] array1 = new int[100];
        int[] array2 = new int[100];
        while (num > 0)
        {
            rem = num % 2;
            num = num / 2;
            array1[k] = rem;
            k++;
        }

        c = a - b;
        for (int i = 1; i < 9; i++)
        {
            d = (int)(2 * c);
            c = (2 * c) - d;
            array2[l] = d;
            l++;
        }

        // second number

        float a1, c1;
        a1 = float.Parse(Console.ReadLine());
        Console.WriteLine("The entered numbers are : {0} and {1}", a, a1);
        int b1, rem1, num1, d1 = 0, k1 = 0, l1 = 0;
        b1 = (int)a1;
        num1 = b1;
        int[] array3 = new int[100];
        int[] array4 = new int[100];
        while (num1 > 0)
        {
            rem1 = num1 % 2;
            num1 = num1 / 2;
            array3[k1] = rem1;
            k1++;
        }

        c1 = a1 - b1;
        for (int i1 = 1; i1 < 9; i1++)
        {
            d1 = (int)(2 * c1);
            c1 = (2 * c1) - d1;
            array4[l1] = d1;
            l1++;
        }

        // array2 and array4 addition

        int n = 7, counter = 0, s;
        int[] array5 = new int[100];
        int[] array6 = new int[100];
        for (int m = 7; m >= 0; m--)
        {
            s = array2[m] + array4[m] + counter;

            if (s == 0)
            {
                array5[n] = 0;
                counter = 0;
            }
            else if (s == 1)
            {
                array5[n] = 1;
                counter = 0;
            }
            else if (s == 2)
            {
                array5[n] = 0;
                counter = 1;
            }
            else
            {
                array5[n] = 1;
                counter = 1;
            }
            n--;
        }

        // array1 and array3 addition

        int n1, counter1 = 0, s1, p;
        if (k > k1)
        {
            n1 = k;
        }
        else
        {
            n1 = k1;
        }
        p = n1;
        for (int m1 = 0; m1 < p; m1++)
        {
            s1 = array1[m1] + array3[m1] + counter1 + counter;

            if (s1 == 0)
            {
                array6[n1] = 0;
                counter1 = 0;
            }
            else if (s1 == 1)
            {
                array6[n1] = 1;
                counter1 = 0;
            }
            else if (s1 == 2)
            {
                array6[n1] = 0;
                counter1 = 1;
            }
            else
            {
                array6[n1] = 1;
                counter1 = 1;
            }
            n1--;
            counter = 0;
        }
        array6[0] = counter1;

        // Printing Binary form of two given numbers

        Console.Write("Binary form of first  number is : ");
        for (int z1 = p; z1 >= 0; z1--)
        {
            Console.Write(array1[z1]);
        }
        Console.Write(".");
        for (int z1 = 0; z1 <= 8; z1++)
        {
            Console.Write(array2[z1]);
        }
        Console.WriteLine(" ");
        Console.Write("Binary form of second number is : ");
        for (int z1 = p; z1 >= 0; z1--)
        {
            Console.Write(array3[z1]);
        }
        Console.Write(".");
        for (int z1 = 0; z1 <= 8; z1++)
        {
            Console.Write(array4[z1]);
        }

        // Printing Binary form of two given numbers

        Console.WriteLine(" ");
        Console.Write("Binary sum  of given numbers is : ");
        for (int z1 = 0; z1 <= p; z1++)
        {
            Console.Write(array6[z1]);
        }
        Console.Write(".");
        for (int z1 = 0; z1 <= 8; z1++)
        {
            Console.Write(array5[z1]);
        }
        double x = 0, y = 0;
        for (int q = 0; q <= p; q++)
        {
            double r = 1;
            for (int i = 0; i < q; i++)
            {
                r = 2 * r;
            }
            x = (array6[p - q] * r) + x;
        }
        for (int q1 = 1; q1 <= 8; q1++)
        {
            double r1 = 1;
            for (int i = 0; i < q1; i++)
            {
                r1 = 2 * r1;
            }
            r1 = 1 / r1;
            y = array5[q1 - 1] * r1 + y;
        }
        Console.WriteLine(" ");
        Console.WriteLine("Sum of {0} and {1} is {2}", a, a1, x + y);
        Console.ReadKey();
    }
}
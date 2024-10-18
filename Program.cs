using System;

namespace @namespace
{
    internal class Program
    {
        static void N4()
        {
            Console.WriteLine("Составьте программу, подсчитывающую количество цифр");
            Console.WriteLine("вводимого вами целого неотрицательного числа.");
            Console.WriteLine("Можно использовать операцию целочисленного деления.");
            Console.WriteLine("цикл for");
            int y = Convert.ToInt32(Console.ReadLine());
            int z = 0;
            if (y == 0) Console.WriteLine(1);
            else
            {
                for (int i = 0; i < y * 100; i++)
                {
                    if (y > 0)
                    {
                        z++;
                        y /= 10;
                    }
                    else break;
                }
                Console.WriteLine(z);
            }
            Console.WriteLine();
            Console.WriteLine("Цикл while");
            int x = Convert.ToInt32(Console.ReadLine());
            int k = 0;
            if (x == 0) Console.WriteLine(1);
            else
            {
                while (x > 0)
                {
                    x /= 10;
                    k++;
                }
                Console.WriteLine(k);
            }

        }
        static void N6()
        {
            Console.WriteLine("Вычислить:  1+2+4+8+...+256");
            Console.WriteLine("цикл for");
            int sum = 0;
            for (int i = 1; i <= 256; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
            Console.WriteLine();
            Console.WriteLine("цикл while");
            sum = 0;
            int j = 1;
            while (j <= 256)
            {

                sum += j;
                j++;
            }
            Console.WriteLine(sum);
        }
        static void N3()
        {
            Console.WriteLine("Напишите программу, определяющую");
            Console.WriteLine("сумму всех нечетных чисел от 1 до 99.");
            Console.WriteLine("цикл for");
            int sum = 0;
            for (int i = 1; i <= 99; i += 2) sum += i;
            Console.WriteLine(sum);
            Console.WriteLine();
            Console.WriteLine("цикл while");
            sum = 0;
            int j = 1;
            while (j <= 99)
            {
                sum += j;
                j += 2;
            }
            Console.WriteLine(sum);
        }
        static void N1()
        {
            Console.WriteLine("Напишите программу вывода всех");
            Console.WriteLine("четных чисел от 2 до 100 включительно");
            Console.WriteLine("цикл for");
            int sum = 0;
            for (int i = 2; i <= 100; i += 2) sum += i;
            Console.WriteLine(sum);
            Console.WriteLine();
            Console.WriteLine("цикл while");
            sum = 0;
            int j = 2;
            while (j <= 100)
            {
                sum += j;
                j += 2;
            }
            Console.WriteLine(sum);
        }
        static void Main(string[] args)
        {
            string s = "";
            Console.WriteLine("Для выхода введите 0");
            while (s != "0")
            {
                Console.WriteLine("Введите номер задания для проверки (4, 6, 3, 1)");
                s = Console.ReadLine();
                if (s == "4") N4();
                else if (s == "6") N6();
                else if (s == "3") N3();
                else if (s == "1") N1();
                Console.WriteLine();
            }

        }
    }
}

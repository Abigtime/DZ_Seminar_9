// N = 3 программа выведит: 3, 2, 1 ; N = 8 программа выдаст: 8, 7, 6, 5, 4, 3, 2, 1.

using System;

class Program
{
    static void Main(string[] args)
    {
        int n = 8;
        PrintNumbers(n);
    }

    static void PrintNumbers(int n)
    {
        if (n == 1)
        {
            Console.Write(n);
            return;
        }

        Console.Write(n + ", ");
        PrintNumbers(n - 1);
    }
}


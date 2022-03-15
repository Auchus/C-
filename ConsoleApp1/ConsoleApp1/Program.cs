using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("написать число");
        int n = Convert.ToInt32(Console.ReadLine());
        if (n <= 0)
        {
            Console.WriteLine($"число {n} не удовлетворяет условие задачи");
        }
        else
        {
            int factorial = 1;
            for (int i = 2; i <= n; i++)
            {
                factorial = factorial * i;
            }
            Console.WriteLine($"Факториал числа {n} = " + factorial);
        }


        Console.WriteLine("написать число");
        int w = Convert.ToInt32(Console.ReadLine());
        if (w <= 0)
        {
            Console.WriteLine($"число {w} не удовлетворяет условие задачи");
        }
        else {
            int m = 0;
            while (w > 0) {
                m = m * 10 + w % 10;
                w /= 10;
            }
            Console.WriteLine($"число задом наперед {w} = {m}");
            
        }
    }
}
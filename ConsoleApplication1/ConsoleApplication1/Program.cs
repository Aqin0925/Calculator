using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random a = new Random();
            Console.WriteLine("请输入你需要的数量");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int num1 = a.Next(1, 100);
                int num2 = a.Next(1, 100);
                int num3;
                int num4 = a.Next(0, 5);
                int num5 = a.Next(1, 10);
                int num6 = a.Next(1, 10);
                int sum;
                switch (num4)
                {
                    case 1: sum = num1 + num2;
                        Console.WriteLine(num1 + "+" + num2 + "=" + sum); break;
                    case 2: sum = num1 - num2;
                        Console.WriteLine(num1 + "-" + num2 + "=" + sum); break;
                    case 3: sum = num1 * num2;
                        Console.WriteLine(num1 + "*" + num2 + "=" + sum); break;
                    case 4: num3 = num5 * num6;
                        Console.WriteLine(num3 + "/" + num5 + "=" + num6); break;
                    default: sum = num1 + num2;
                        Console.WriteLine(num1 + "+" + num2 + "=" + sum); break;
                }
            }
            Console.ReadKey();
        }
    }
}

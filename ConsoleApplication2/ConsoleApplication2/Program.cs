using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class StupidPasswordGenerator
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Don't write a number higher than 10 !!!");
        Console.WriteLine();
        Console.Write("Write the number of the integers : ");
        int numbers = 1;
        var o = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine();
        double num1 = 0;
        double num2 = 0;
        double num3 = 0;
        double num4 = 0;
        double num5 = 0;
        double num6 = 0;
        double num7 = 0;
        double num8 = 0;
        double num9 = 0;
        double num10 = 0;



        if (o <= 10)
        {
            for (int i = 1; i <= o; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Integer number {0} : ", numbers);
                double num = double.Parse(Console.ReadLine());
                if (i == 1)
                {
                    num1 += num;
                }
                else if (i == 2)
                {
                    num2 += num;
                }
                else if (i == 3)
                {
                    num3 += num;
                }
                else if (i == 4)
                {
                    num4 += num;
                }
                else if (i == 5)
                {
                    num5 += num;
                }
                else if (i == 6)
                {
                    num6 += num;
                }
                else if (i == 7)
                {
                    num7 += num;
                }
                else if (i == 8)
                {
                    num8 += num;
                }
                else if (i == 9)
                {
                    num9 += num;
                }
                else if (i == 10)
                {
                    num10 += num;
                }
                numbers++;

            }
            double num1w = Math.Max(num1, num2);
            double num2w = Math.Max(num3, num4);
            double num3w = Math.Max(num5, num6);
            double num4w = Math.Max(num7, num8);
            double num5w = Math.Max(num9, num10);

            double numbw1 = Math.Max(num1w, num2w);
            double numbw2 = Math.Max(num3w, num4w);
            double numbw3 = Math.Max(num5w, numbw2);

            double numww1 = Math.Max(numbw1, numbw2);
            double numafw = Math.Max(numww1, numbw2);
            double numfw = Math.Max(numafw, numww1);

            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("The biggest number is : {0}", numfw);
            Console.WriteLine();
            Console.WriteLine();
        }
        else if (o > 10)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You can't do anything with more than 10 integers! :)");
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}

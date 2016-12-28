using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication93
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of the lines: ");
            int lines = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter number of the columns: ");
            int columns = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter first symbol: ");
            string Symbol1 = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Enter second symbol: ");
            string Symbol2 = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Enter divider: ");
            string divider = Console.ReadLine();
            Console.WriteLine();

            for (int j = 1; j <= lines; j++)
            {
                if (j % 2 != 0)
                {
                    for (int i = 1; i <= columns; i++)
                    {
                        if (i < columns)
                        {
                            if (i % 2 != 0)
                            {
                                Console.Write("{0}{1}", Symbol1, divider);
                            }
                            else if (i % 2 == 0)
                            {
                                Console.Write("{0}{1}", Symbol2, divider);
                            }
                        }
                        else if (i == columns)
                        {
                            if (i % 2 != 0)
                            {
                                Console.WriteLine("{0}", Symbol1);
                            }
                            else if (i % 2 == 0)
                            {
                                Console.WriteLine("{0}", Symbol2);
                            }
                        }
                    }
                }
                else if (j % 2 == 0)
                {
                    for (int i = 1; i <= columns; i++)
                    {
                        if (i < columns)
                        {
                            if (i % 2 != 0)
                            {
                                Console.Write("{0}{1}", Symbol2, divider);
                            }
                            else if (i % 2 == 0)
                            {
                                Console.Write("{0}{1}", Symbol1, divider);
                            }
                        }
                        else if (i == columns)
                        {
                            if (i % 2 != 0)
                            {
                                Console.WriteLine("{0}", Symbol2);
                            }
                            else if (i % 2 == 0)
                            {
                                Console.WriteLine("{0}", Symbol1);
                            }
                        }
                    }
                }
            }
        }
    }
}

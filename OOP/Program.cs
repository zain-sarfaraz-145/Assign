using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
        start:
            Console.Write("Select Menu from the List");
            Console.Write("\n1.Addition");
            Console.Write("\n2.Swapping");
            Console.Write("\n3.Even and Odd");
            Console.Write("\n4.Factorial");
            Console.Write("\n5.Exit");
            Console.Write("\nEnter Your Choice: ");
            int choice = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (choice)
            {
                case 1:
                    Console.Write("Enter 1st Number: ");
                    int a = int.Parse(Console.ReadLine());
                    Console.Write("Enter 2nd Number: ");
                    int b = int.Parse(Console.ReadLine());
                    int sum = a + b;
                    Console.Write("Sum is: " + sum + "\n\n\n");
                    break;
                case 2:
                    Console.Write("Enter 1st Number: ");
                    int c = int.Parse(Console.ReadLine());
                    Console.Write("Enter 2nd Number: ");
                    int d = int.Parse(Console.ReadLine());
                    Console.Write("\nBefore Swapping value of a and b is a=" + c + " and b=" + d);
                    c = c + d;
                    d = c - d;
                    c = c - d;
                    Console.Write("\n\nAfter Swapping value of a and b is a=" + c + " and b=" + d + "\n\n\n");
                    break;
                case 3:
                    Console.Write("Enter any Number: ");
                    int e = int.Parse(Console.ReadLine());
                    if (e % 2 == 0)
                    {
                        Console.Write(e + " is Even Number" + "\n\n\n");
                    }
                    else
                    {
                        Console.Write(e + " is Odd Number" + "\n\n\n");
                    }
                    break;
                case 4:
                    Console.Write("Enter Any Number: ");
                    int g = int.Parse(Console.ReadLine());
                    int f;
                    f = g;
                    for (int h = 1; h < g; h++)
                    {
                        f = f * h;
                    }
                    Console.Write("Factorial of " + g + " is " + f + "\n\n\n");
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid Selection" + "\n\n\n");
                    break;
            }
            goto start;
            Console.ReadKey();
        }
    }
}

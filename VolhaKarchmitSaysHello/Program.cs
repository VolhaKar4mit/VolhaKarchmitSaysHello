using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Security.Cryptography;
using System.Xml.Linq;

class Program
{
    private static void Main(string[] args)
    {
        Task1();
        Task2();
        Task3();
        Task4();
        Task5();
        Task6();
        Task7();
        Task8();
        Task9();
    }

    private static void Task1()
    {
        var num = 20;
        num += 5;

        Console.WriteLine(num);
    }

    private static void Task2()
    {
        Console.WriteLine("Enter a number: ");

        var number = Console.ReadLine();
        if (number.Length != 4)
        {
            Console.WriteLine("Enter a four-digit number");
        }
        else if (number.Length < 1000)
        {
            Console.WriteLine("number cant starts from 0");
        }
        else
        {
            int n = int.Parse(number);
            int years = n / 365;
            int months = (n % 365) % 12;
            int days = (n % 365) % 7;

            Console.WriteLine("years: " + years + ", " + "months: " + months + ", days: " + days);
            Console.ReadLine();
        }
    }

    private static void Task3()
    {
        Console.WriteLine("Enter a number: ");
        var number = Console.ReadLine();
        int n = int.Parse(number);
        int a = n * 2;
        Console.WriteLine(n + a);
    }

    private static void Task4()
    {
        sbyte age = -34;
        byte year = 4;
        string greetings = "Hello";
        char a = "R";
        double value = 23.093433222;
        int price = 40000;
        bool winter = true;
        byte sugar = 0;
    }

    private static void Task5()
    {
        Console.WriteLine("How old are you ?: ");
        var age = Console.ReadLine();
        short _age = short.Parse(age);

        Console.WriteLine("What is your year go birth ?: ");
        var year = Console.ReadLine();
        ulong _year = ulong.Parse(year);

        Console.WriteLine("First latter of your name ?: ");
        var abb = Console.ReadLine();
        char _abb = char.Parse(abb);

        Console.WriteLine("What is your height ?: ");
        var height = Console.ReadLine();
        double _height = double.Parse(height);
    }

    private static void Task6()
    {
        sbyte x1 = -5;
        x1 *= 7;
        int x2 = x1--;
        Console.WriteLine(x1);
        Console.WriteLine(x2);

    }

    private static void Task7()

    {
        int x;
        Console.Write("введите число: ");
        x = Console.Read();

        if (x % 2 != 0)
        {
            Console.WriteLine("this is an odd number");

        }
        else
        {
            Console.WriteLine("this is an even number");
        }

        Console.ReadKey();
    }
    private static void Task8()
    {
        int a;
        Console.Write("Enter a number: ");
        a = Console.Read();


        if (a < 50 && a != 37 && a > 32 && a == 0)
        {
            Console.WriteLine("Working");

        }

        else _ = (a == 15);
        {
            Console.WriteLine("Working");
        }
        Console.ReadKey();
    }
    private static void Task9()
    {
        int x = 0;
        int y = 0;
        Console.WriteLine("enter a number1: ");
        x = int.Parse(Console.ReadLine());
        Console.WriteLine("enter a number2: ");
        y = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter an action: ");
        var act = Console.ReadLine();

        switch (act)
        {
            case "+":
                Console.WriteLine(x + y);
                break;
            case "-":
                Console.WriteLine(x - y);
                break;
            case "*":
                Console.WriteLine(x * y);
                break;
            case "/":
                if (y == 0)
                {
                    Console.WriteLine("деление на ноль");
                    break;
                }
                else
                {
                    Console.WriteLine(x / y);
                    break;
                }
            default:
                return;
        }
    }
}





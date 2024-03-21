// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        bool continueRunning = true;

        while (continueRunning)
        {
            Console.WriteLine("1. Iєрархя класiв ");
            Console.WriteLine("2. Trans");
            Console.WriteLine("3. Стандартнi iнтерфейси .NET");

            char choice = Console.ReadKey().KeyChar;
            Console.WriteLine();

            switch (choice)
            {
                case '1':
                    task1();
                    break;
                case '2':
                    task2();
                    break;
                case '3':
                    task3();
                    break;
                default:
                    Console.WriteLine("Неправильний вибiр.");
                    break;
            }

            Console.WriteLine("Бажаєте продовжити? (Y/N)");
            char continueChoice = Console.ReadKey().KeyChar;
            Console.WriteLine();

            continueRunning = (continueChoice == 'Y' || continueChoice == 'y');
        }

        Console.WriteLine("Натиснiть будь-яку клавiшу, щоб вийти...");
        Console.ReadKey();
    }

    static void task1()
    {
        // Приклад використання
        Ungulate horse = new Ungulate
        {
            Name = "Horse",
            FurColor = "Brown",
            Hooves = true
        };
        horse.Show();
        horse.Display();

        Bird eagle = new Bird
        {
            Name = "Eagle",
            FeatherColor = "Brown"
        };
        eagle.Show();
        eagle.Display();
        eagle.DotNetFunctionality();

    }

    static void task2()
    {
        // Приклад використання
        MyDerivedClass obj = new MyDerivedClass();
        obj.CustomFunctionality();
        obj.Dispose();
        obj.Clone();
    }

    static void task3()
    {
        // Створення бази транспортних засобiв
        Truck[] trucks = new Truck[]
        {
            new Truck("Volvo", "IJ91011KL", 80, 2000, false),
            new Truck("MAN", "MN121314OP", 70, 3000, true)
        };

        // Використання оператора foreach для перебору вантажiвок
        Console.WriteLine("All trucks:");
        foreach (var truck in trucks)
        {
            truck.DisplayInfo();
        }
    }
}
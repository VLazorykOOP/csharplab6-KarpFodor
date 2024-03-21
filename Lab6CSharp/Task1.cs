using System;

// Інтерфейс користувача
interface IUserInterface
{
    void Display();
}

// Інтерфейс .NET.C#
interface IDotNetInterface
{
    void DotNetFunctionality();
}

// Базовий клас Тварина
abstract class Animal : IUserInterface
{
    public string Name { get; set; }
    public abstract void Show();

    public void Display()
    {
        Console.WriteLine($"Name: {Name}");
    }
}

// Похідний клас Савець
class Mammal : Animal
{
    public string FurColor { get; set; }

    public override void Show()
    {
        Console.WriteLine($"Name: {Name}, Fur Color: {FurColor}");
    }
}

// Похідний клас Парнокопитне
class Ungulate : Mammal
{
    public bool Hooves { get; set; }

    public override void Show()
    {
        Console.WriteLine($"Name: {Name}, Fur Color: {FurColor}, Hooves: {Hooves}");
    }
}

// Похідний клас Птах
class Bird : Animal, IDotNetInterface
{
    public string FeatherColor { get; set; }

    public override void Show()
    {
        Console.WriteLine($"Name: {Name}, Feather Color: {FeatherColor}");
    }

    public void DotNetFunctionality()
    {
        Console.WriteLine("This is a .NET function for birds.");
    }
}



using System;

// Інтерфейс, що успадковує інтерфейси .NET
interface ICustomInterface : IDisposable, ICloneable
{
    void CustomFunctionality();
}

// Базовий клас
class MyBaseClass
{
    public string BaseField { get; set; }
}

// Похідний клас, який реалізує інтерфейс
class MyDerivedClass : MyBaseClass, ICustomInterface
{
    public void CustomFunctionality()
    {
        Console.WriteLine("Custom functionality implemented.");
    }

    public void Dispose()
    {
        Console.WriteLine("Dispose method implemented.");
    }

    public object Clone()
    {
        Console.WriteLine("Clone method implemented.");
        return this.MemberwiseClone();
    }
}



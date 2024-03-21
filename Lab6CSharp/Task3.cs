using System;
using System.Collections;
using System.Collections.Generic;

// Інтерфейс транспортного засобу
interface ITransport
{
    void DisplayInfo();
    int GetPayloadCapacity();
}

// Базовий клас Транспортний засіб
class Vehicle : ITransport
{
    public string Brand { get; set; }
    public string Number { get; set; }
    public int Speed { get; set; }
    public int PayloadCapacity { get; protected set; }

    public Vehicle(string brand, string number, int speed, int payloadCapacity)
    {
        Brand = brand;
        Number = number;
        Speed = speed;
        PayloadCapacity = payloadCapacity;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Brand: {Brand}, Number: {Number}, Speed: {Speed}, Payload Capacity: {PayloadCapacity}");
    }

    public virtual int GetPayloadCapacity()
    {
        return PayloadCapacity;
    }
}

// Похідний клас Вантажівка
class Truck : Vehicle, IEnumerable
{
    public bool Trailer { get; set; }

    public Truck(string brand, string number, int speed, int payloadCapacity, bool trailer) : base(brand, number, speed, payloadCapacity)
    {
        Trailer = trailer;
        if (trailer)
        {
            PayloadCapacity *= 2; // Якщо є причіп, вантажопідйомність збільшується у два рази
        }
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Brand: {Brand}, Number: {Number}, Speed: {Speed}, Payload Capacity: {PayloadCapacity}, Trailer: {Trailer}");
    }

    public override int GetPayloadCapacity()
    {
        return PayloadCapacity;
    }

    // Реалізація інтерфейсу IEnumerable
    public IEnumerator GetEnumerator()
    {
        return new TruckEnumerator(this);
    }

    // Клас-ітератор для перебору вантажівок
    private class TruckEnumerator : IEnumerator
    {
        private Truck _truck;
        private int _index;

        public TruckEnumerator(Truck truck)
        {
            _truck = truck;
            _index = -1;
        }

        public object Current => _truck;

        public bool MoveNext()
        {
            _index++;
            return _index < 1; // Приклад, якщо у вас лише одна вантажівка в колекції
        }

        public void Reset()
        {
            _index = -1;
        }
    }
}



using System;

class Car
{
    public string ModelName;
    public string Manufacturer;
    public int YearOfProduction;
    public double EngineCapacity;
    public int SeatCount;
    public bool IsElectric;
    public double AverageFuelConsumption;

    public double GetFuelConsumptionPer100Km()
    {
        return AverageFuelConsumption;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введіть модель автомобіля: ");
        string modelName = Console.ReadLine();

        Console.Write("Введіть виробника: ");
        string manufacturer = Console.ReadLine();

        Console.Write("Введіть рік випуску: ");
        string yearOfProductionStr = Console.ReadLine();

        Console.Write("Введіть об'єм двигуна (л): ");
        string engineCapacityStr = Console.ReadLine();

        Console.Write("Введіть кількість місць: ");
        string seatCountStr = Console.ReadLine();

        Console.Write("Чи є автомобіль електричним? (y - так, n - ні): ");
        ConsoleKeyInfo isElectricKey = Console.ReadKey();
        Console.WriteLine();

        Console.Write("Введіть середню витрату палива (л/100 км): ");
        string averageFuelConsumptionStr = Console.ReadLine();

        // Створення екземпляра Car
        Car myCar = new Car();
        myCar.ModelName = modelName;
        myCar.Manufacturer = manufacturer;
        myCar.YearOfProduction = int.Parse(yearOfProductionStr);
        myCar.EngineCapacity = double.Parse(engineCapacityStr);
        myCar.SeatCount = int.Parse(seatCountStr);
        myCar.IsElectric = isElectricKey.Key == ConsoleKey.Y ? true : false;
        myCar.AverageFuelConsumption = double.Parse(averageFuelConsumptionStr);

        // Виведення інформації
        Console.WriteLine("\nДані про автомобіль:");
        Console.WriteLine("Модель: " + myCar.ModelName);
        Console.WriteLine("Виробник: " + myCar.Manufacturer);
        Console.WriteLine("Рік випуску: " + myCar.YearOfProduction);
        Console.WriteLine("Об'єм двигуна: " + myCar.EngineCapacity + " л");
        Console.WriteLine("Кількість місць: " + myCar.SeatCount);
        Console.WriteLine("Електричний: " + (myCar.IsElectric ? "Так" : "Ні"));
        Console.WriteLine("Середня витрата палива (л/100 км): " + myCar.GetFuelConsumptionPer100Km().ToString("0.00"));

        Console.ReadKey();
    }
}

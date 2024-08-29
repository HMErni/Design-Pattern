using AbstractFactory.Interfaces;
using AbstractFactory.Model;
using AbstractFactory.Model.Factory;

namespace AbstractFactory;

public class Program
{
    public static void Main()
    {
        FerrariFactory ferrariFactory = new FerrariFactory();
        ToyotaFactory toyotaFactory = new ToyotaFactory();

        var ferrariCars = new List<ICar>();
        var toyotaCars = new List<ICar>();


        ferrariCars.Add(ferrariFactory.CreateCar("F-Normal-Car", "Black", 10000));
        ferrariCars.Add(ferrariFactory.CreateSuperCar("F-Super-Car", "Red and Black", 100000));


        toyotaCars.Add(toyotaFactory.CreateCar("T-Normal-Car", "Red", 5000));
        toyotaCars.Add(toyotaFactory.CreateIndustrialCar("T-Industrial-Car", "Yellow", 7500));
        toyotaCars.Add(toyotaFactory.CreateSuperCar("T-Super-Car", "Red and Yellow", 50000));



        Console.WriteLine("\n\nFerrari Cars:");
        foreach (var car in ferrariCars)
            Console.WriteLine(car);

        Console.WriteLine("\n\nToyota Cars:");
        foreach (var car in toyotaCars)
            Console.WriteLine(car);


        // Console.WriteLine("\n\nTest Ferrari Cars:");
        // foreach (var car in ferrariCars)
        // {

        //     car.Describe();
        //     car.Start();

        //     if (car is ISuperCar superCar)
        //         superCar.GonnaGoFast();

        //     if (car is IIndustrialCar industrialCar)
        //         industrialCar.DoSomethingIndustrial();

        //     car.Stop();
        // }

        // Console.WriteLine("\n\nTest Toyota Cars:");
        // foreach (var car in toyotaCars)
        // {
        //     car.Describe();
        //     car.Start();

        //     if (car is ISuperCar superCar)
        //         superCar.GonnaGoFast();

        //     if (car is IIndustrialCar industrialCar)
        //         industrialCar.DoSomethingIndustrial();

        //     car.Stop();

        //     Console.WriteLine("");
        // }
    }
}
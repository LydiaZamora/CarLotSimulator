using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var lot = new CarLot();

            var randomCar = new Car();
            randomCar.Year = 2018;
            randomCar.Make = "Ford";
            randomCar.Model = "Focus";
            randomCar.EngineNoise = "vroom";
            randomCar.HonkNoise = "meep meep";
            randomCar.IsDriveable = true;

            randomCar.MakeEngineNoise();
            randomCar.MakeHonkNoise();

            var newCar = new Car()
            {
                Year = 2024,
                Make = "Subaru",
                Model = "Outback",
                EngineNoise = "vroom vroom",
                HonkNoise = "beeeep",
                IsDriveable = true,
            };

            newCar.MakeEngineNoise();
            newCar.MakeHonkNoise();

            var oldCar = new Car(1998, "Honda", "Civic", "vrooom", "meep", false);

            oldCar.MakeEngineNoise();
            oldCar.MakeHonkNoise();

            lot.carDataBase.Add(randomCar);
            lot.carDataBase.Add(newCar);
            lot.carDataBase.Add(oldCar);

            foreach(var car in lot.carDataBase)
            {
                Console.WriteLine($"Year: {car.Year} | Make: {car.Make} | Model: {car.Model}");
            }

            //*************BONUS X 2*************//


            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console


        }
    }
}

using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiated a new object using the CarLot class
            // so I can now access properties etc.
            var lot = new CarLot();

            //instantiated random car using the class Car - make new object

            var randomCar = new Car();

            // adding properties to this new object
            randomCar.Year = 2018;
            randomCar.Make = "Ford";
            randomCar.Model = "Focus";
            randomCar.EngineNoise = "vroom";
            randomCar.HonkNoise = "meep meep";
            randomCar.IsDriveable = true;

            //called methods from car class

            randomCar.MakeEngineNoise();
            randomCar.MakeHonkNoise();

            //use onject initialization syntax

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

            //use method that calls in ALL arguments
            //passed into constructor from car class

            var oldCar = new Car(1998, "Honda", "Civic", "vrooom", "meep", false);

            oldCar.MakeEngineNoise();
            oldCar.MakeHonkNoise();

            //Added cars to carlot List named carDataBase

            lot.carDataBase.Add(randomCar);
            lot.carDataBase.Add(newCar);
            lot.carDataBase.Add(oldCar);


            //used foreach loop to print the cars' tear make
            //and model in the list carDataBase to console screend

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

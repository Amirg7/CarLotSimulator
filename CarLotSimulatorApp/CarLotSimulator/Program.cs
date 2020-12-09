using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //DONE

            //Instanciate the a Carlot at the beginning of the program
            //and as you create a car add the car to the list.
            var lot = new CarLot();
            

            //Done - Create a seperate class file called Car
            //Done - Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Done - Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //Done - The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //Instantiation 1
            var michaelsCar = new Car();

            michaelsCar.Make = "Ford";
            michaelsCar.Model = "Focus";
            michaelsCar.Year = 2013;
            michaelsCar.EngineNoise = "vroom";
            michaelsCar.HonkNoise = "beep";
            michaelsCar.IsDrivable = true;

            lot.Cars.Add(michaelsCar);

            //Instantiation 2
            var stevesCar = new Car()
            {
                Year = 2019,
                Make = "Tesla",
                Model = "Cyber Truck",
                EngineNoise = "...",
                HonkNoise = "brmmp",
                IsDrivable = false
            };

            //add stevescar to the carlot
            lot.Cars.Add(stevesCar);

            //Instantiation 3
            var brettsCar = new Car(2013, "Honda", "Civic", "Vrrroom", "vruuuga", true);

            //add brettscar to the carlot
            lot.Cars.Add(brettsCar);

            //Call methods
            michaelsCar.MakeEngineNoise();
            stevesCar.MakeEngineNoise();
            brettsCar.MakeEngineNoise();


            //*************BONUS*************//

            // Done - Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Done - Create a CarLot class
            //Done - It should have at least one property: a List of cars
            //Done - At the end iterate through the list printing each of car's Year, Make, and Model to the console

            foreach (var car in lot.Cars)
            {
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model: {car.Model}");
            }

        }
    }
}

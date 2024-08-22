using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
             

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            //
            {


                var chevy = new Car();
                
                chevy.Model = "Chevy";
                chevy.Make = "Trailblazer SS";
                chevy.Year = 2023;
                chevy.HonkNoise = "IceCream truck";
                chevy.EngineNoise = "Like a 5.0 Mustang";
                chevy.IsDriveable = true;
                chevy.MakeEngineNoise("like a 5.0 mustang");
                chevy.MakeHonkNoise("like a icecream truck");
                
                Console.WriteLine($"This is my {chevy.Model} {chevy.Make} {chevy.Year}.");
                Console.WriteLine($"My horn sounds like a {chevy.HonkNoise} the engine sounds {chevy.EngineNoise}.");
                Console.WriteLine($"{chevy.IsDriveable} this is the fastest truck iv'e had.");
                Console.WriteLine();

            }

            { 
                var chevrolet = new Car();
                
                chevrolet.Model = "Chevrolet";
                chevrolet.Make = "Monte Carlo SS";
                chevrolet.Year = 1970;
                chevrolet.HonkNoise = "loud";
                chevrolet.EngineNoise = "nice smooth growl";
                chevrolet.IsDriveable = true;
                chevrolet.MakeEngineNoise("nice smooth growl");
                chevrolet.MakeHonkNoise("loud");
                
                Console.WriteLine($"This is my {chevrolet.Model} {chevrolet.Make} {chevrolet.Year}.");
                Console.WriteLine($"the engine on this car is a {chevrolet.EngineNoise} with a {chevrolet.HonkNoise} horn.");
                Console.WriteLine($"{chevrolet.IsDriveable} i really cant pick which car i like the most.");
                Console.WriteLine();
            }


            {
                
                var dodge  = new Car();
              
                dodge.Model = "Dodge";
                dodge.Make = "Charger Scat pack";
                dodge.Year = 2023;
                dodge.HonkNoise = "Loud";
                dodge.EngineNoise = "Like a Big Mean Cat growling";
                dodge.IsDriveable = true;
                dodge.MakeEngineNoise("like a big mean cat growling");
                dodge.MakeHonkNoise("loud");
                
                Console.WriteLine($"This is my {dodge.Make} {dodge.Model} {dodge.Year}.");
                Console.WriteLine($"My horn is {dodge.HonkNoise} also the engine is {dodge.EngineNoise}.");
                Console.WriteLine($"{dodge.IsDriveable} i loving driving this car.");
                Console.WriteLine();
            }


            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car


            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}

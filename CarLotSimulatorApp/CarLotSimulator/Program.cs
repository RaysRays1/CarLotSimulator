using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

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


                var CarOne = new Car();
                
                CarOne.Model = "Chevy";
                CarOne.Make = "Trailblazer SS";
                CarOne.Year = 2023;
                CarOne.HonkNoise = "IceCream truck";
                CarOne.EngineNoise = "Like a 5.0 Mustang";
                CarOne.IsDriveable = true;
                CarOne.MakeEngineNoise("like a 5.0 mustang");
                CarOne.MakeHonkNoise("like a icecream truck");
                
                Console.WriteLine($"This is my {CarOne.Model} {CarOne.Make} {CarOne.Year}.");
                Console.WriteLine($"My horn sounds like a {CarOne.HonkNoise} the engine sounds {CarOne.EngineNoise}.");
                Console.WriteLine($"{CarOne.IsDriveable} this is the fastest truck iv'e had.");
                Console.WriteLine();

            }

            { 
                var CarTwo = new Car();
                    
                CarTwo.Model = "Chevrolet";
                CarTwo.Make = "Monte Carlo SS";
                CarTwo.Year = 1970;
                CarTwo.HonkNoise = "loud";
                CarTwo.EngineNoise = "nice smooth growl";
                CarTwo.IsDriveable = true;
                CarTwo.MakeEngineNoise("nice smooth growl");
                CarTwo.MakeHonkNoise("loud");
                
                Console.WriteLine($"This is my {CarTwo.Model} {CarTwo.Make} {CarTwo.Year}.");
                Console.WriteLine($"the engine on this car is a {CarTwo.EngineNoise} with a {CarTwo.HonkNoise} horn.");
                Console.WriteLine($"{CarTwo.IsDriveable} i really cant pick which car i like the most.");
                Console.WriteLine();
            }


            {
                
                var CarThree  = new Car();
              
                CarThree.Model = "Dodge";
                CarThree.Make = "Charger Scat pack";
                CarThree.Year = 2023;
                CarThree.HonkNoise = "Loud";
                CarThree.EngineNoise = "Like a Big Mean Cat growling";
                CarThree.IsDriveable = true;
                CarThree.MakeEngineNoise("like a big mean cat growling");
                CarThree.MakeHonkNoise("loud");
                
                Console.WriteLine($"This is my {CarThree.Make} {CarThree.Model} {CarThree.Year}.");
                Console.WriteLine($"My horn is {CarThree.HonkNoise} also the engine is {CarThree.EngineNoise}.");
                Console.WriteLine($"{CarThree.IsDriveable} i loving driving this car.");
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

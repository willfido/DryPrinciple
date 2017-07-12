using DryPrinciple.Enums;
using DryPrinciple.Example1.RepeatingCode;
using DryPrinciple.Example2.MagicStrings;
using DryPrinciple.Example3.Oop;
using DryPrinciple.Interfaces;
using System;

namespace DryPrinciple
{
    class Program
    {
        // magic string resolved with a variable.
        static readonly int expectedArgumentCount = 2;

        static void Main(string[] args)
        {
            if (args.Length == expectedArgumentCount)
            {
                var example = args[0];
                var principle = args[1];

                //Wet(principle, example);
                Dry(principle, example);
            }
            else
            {
                Console.WriteLine("Youe need to give an example and a principle");
            }
        }

        static void Wet(string principle, string example)
        {
            var repeatCode = new RepeatCodeDry();
            MagicStringsDry magicString = new MagicStringsDry();
            OopDryFruit fruit = new OopDryFruit();
            OopDryCars cars = new OopDryCars();

            if (principle == "dry")
            {
                switch (example)
                {
                    case "1":
                        Console.WriteLine(repeatCode.GetFruits());
                        Console.WriteLine(repeatCode.GetCarNames());
                        break;
                    case "2":
                        Console.WriteLine("Previous");
                        Console.WriteLine(repeatCode.GetFruits());
                        Console.WriteLine(repeatCode.GetCarNames());
                        Console.WriteLine("Changed");
                        Console.WriteLine(magicString.GetFruits());
                        Console.WriteLine(magicString.GetCarNames());
                        break;
                    case "3":
                        Console.WriteLine("Previous");
                        Console.WriteLine(magicString.GetFruits());
                        Console.WriteLine(magicString.GetCarNames());
                        Console.WriteLine("Changed");
                        Console.WriteLine(fruit.GetList());
                        Console.WriteLine(cars.GetList());
                        break;
                }
            }
            else
            {
                switch (example)
                {
                    case "1":
                        var repeatCodeExample = new RepeatCodeWet();
                        Console.WriteLine(repeatCodeExample.GetFruits());
                        Console.WriteLine(repeatCodeExample.GetCarNames());
                        break;
                    case "2":
                        Console.WriteLine("Previous");
                        Console.WriteLine(repeatCode.GetFruits());
                        Console.WriteLine(repeatCode.GetCarNames());
                        Console.WriteLine("Changed");
                        Console.WriteLine(magicString.GetFruits());
                        Console.WriteLine(magicString.GetCarNames());
                        break;
                    case "3":
                        Console.WriteLine("Previous");
                        Console.WriteLine(magicString.GetFruits());
                        Console.WriteLine(magicString.GetCarNames());
                        Console.WriteLine("Changed");
                        Console.WriteLine(fruit.GetList());
                        Console.WriteLine(cars.GetList());
                        break;
                }
            }
        }

        static void Dry(string principle, string example)
        {
            //resolving the repeating switch with an interface
            IExample repeatCode;
            IExample magicString = new MagicStringsDry();
            OopDryFruit fruit = new OopDryFruit();
            OopDryCars cars = new OopDryCars();

            if (principle == Principle.Dry.ToString().ToLower())
            {
                repeatCode = new RepeatCodeDry();
            }
            else
            {
                repeatCode = new RepeatCodeWet();
            }

            switch (example)
            {
                case "1":
                    Console.WriteLine(repeatCode.GetFruits());
                    Console.WriteLine(repeatCode.GetCarNames());
                    break;
                case "2":
                    Console.WriteLine("Previous");
                    Console.WriteLine(repeatCode.GetFruits());
                    Console.WriteLine(repeatCode.GetCarNames());
                    Console.WriteLine("Changed");
                    Console.WriteLine(magicString.GetFruits());
                    Console.WriteLine(magicString.GetCarNames());
                    break;
                case "3":
                    Console.WriteLine("Previous");
                    Console.WriteLine(magicString.GetFruits());
                    Console.WriteLine(magicString.GetCarNames());
                    Console.WriteLine("Changed");
                    Console.WriteLine(fruit.GetList());
                    Console.WriteLine(cars.GetList());
                    break;
            }
        }
    }
}

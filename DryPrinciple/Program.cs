﻿using DryPrinciple.Example1.RepeatingCode;
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

                Wet(principle, example);
                Dry(principle, example);
            }
            else
            {
                Console.WriteLine("Youe need to give an example and a principle");
            }
        }

        static void Wet(string principle, string example)
        {
            if (principle == "dry")
            {
                switch (example)
                {
                    case "1":
                        var repeatCodeExample = new RepeatCodeDry();
                        Console.WriteLine(repeatCodeExample.GetFruits());
                        Console.WriteLine(repeatCodeExample.GetCarNames());
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
                }
            }
        }

        static void Dry(string principle, string example)
        {
            //resolving the repeating switch with an interface
            IExample repeatCode;

            if (principle == "dry")
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
            }
        }
    }
}

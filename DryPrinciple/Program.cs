using DryPrinciple.Example1.RepeatingCode;
using System;

namespace DryPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 2)
            {
                var example = args[0];
                var principle = args[1];

                if (principle == "dry")
                {
                    switch (example)
                    {
                        case "1":
                            var repeatCodeExample = new RepeatCodeDry();
                            break;
                        default:
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
                        default:
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Youe need to give an example and a principle");
            }
        }
    }
}

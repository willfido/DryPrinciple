using DryPrinciple.Interfaces;
using System.Collections.Generic;
using System.Text;

namespace DryPrinciple.Example1.RepeatingCode
{
    class RepeatCodeWet : IExample
    {
        public string GetFruits()
        {
            var fruitsSb = new StringBuilder();

            var fruitList = new List<string> { "banana", "pear", "apple" };

            //1. RepeatCode
            foreach (var fruit in fruitList)
            {
                fruitsSb.Append(fruit).Append(",");
            }

            return fruitsSb.ToString();
        }

        public string GetCarNames()
        {
            var fruitsSb = new StringBuilder();

            var carNames = new List<string> { "skoda", "ford", "mazda" };

            //1. Repeat Code
            foreach (var carName in carNames)
            {
                fruitsSb.Append(carName).Append(",");
            }

            return fruitsSb.ToString();
        }
    }
}

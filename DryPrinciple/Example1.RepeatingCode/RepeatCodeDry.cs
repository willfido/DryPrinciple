using DryPrinciple.Interfaces;
using System.Collections.Generic;
using System.Text;

namespace DryPrinciple.Example1.RepeatingCode
{
    class RepeatCodeDry : IExample
    {
        public string GetFruits()
        {
            var fruitList = new List<string> { "banana", "pear", "apple" };

            return GetValues(fruitList);
        }

        public string GetCarNames()
        {
            var carNames = new List<string> { "skoda", "ford", "mazda" };

            return GetValues(carNames);
        }

        //we can eliminate the redundancy by using a method.
        private string GetValues(IEnumerable<string> collection)
        {
            var sb = new StringBuilder();

            foreach (var item in collection)
            {
                sb.Append(item).Append(",");
            }

            sb.Remove(sb.Length - 1, 1);

            return sb.ToString();
        }
    }
}

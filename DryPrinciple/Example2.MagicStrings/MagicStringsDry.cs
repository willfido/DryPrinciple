using DryPrinciple.Interfaces;
using System.Collections.Generic;
using System.Text;

namespace DryPrinciple.Example2.MagicStrings
{
    class MagicStringsDry : IExample
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

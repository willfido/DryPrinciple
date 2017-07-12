using DryPrinciple.Enums;
using DryPrinciple.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DryPrinciple.Example2.MagicStrings
{
    class MagicStringsDry : IExample
    {
        public string GetFruits()
        {
            var fruitList = Enum.GetNames(typeof(Fruit));

            return GetValues(fruitList);
        }

        public string GetCarNames()
        {
            var carNames = Enum.GetNames(typeof(CarMake));

            return GetValues(carNames);
        }

        private string GetValues(IEnumerable<string> collection)
        {
            var sb = new StringBuilder();

            foreach (var item in collection)
            {
                sb.Append(item).Append(",");
            }

            //using the extension method on string to remove teh trailing ,
            return sb.ToString().TrimEnd(',');
        }
    }
}

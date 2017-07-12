using System.Collections.Generic;
using System.Text;

namespace DryPrinciple.Example1.RepeatingCode
{
    class RepeatCodeWet : IRepeatCode
    {
        public string GetFruits()
        {
            StringBuilder fruitsSb = new StringBuilder();

            List<string> fruitList = new List<string>();

            fruitList.Add("banana");
            fruitList.Add("pear");
            fruitList.Add("apple");

            foreach (var fruit in fruitList)
            {
                fruitsSb.Append(fruit).Append(",");
            }

            return fruitsSb.ToString();
        }

        public string GetCarNames()
        {
            StringBuilder fruitsSb = new StringBuilder();

            List<string> carNames = new List<string>();

            carNames.Add("skoda");
            carNames.Add("ford");
            carNames.Add("mazda");

            foreach (var carName in carNames)
            {
                fruitsSb.Append(carName).Append(",");
            }

            return fruitsSb.ToString();
        }
    }
}

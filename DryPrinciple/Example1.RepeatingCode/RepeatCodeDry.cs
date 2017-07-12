using System.Collections.Generic;
using System.Text;

namespace DryPrinciple.Example1.RepeatingCode
{
    class RepeatCodeDry
    {
        public string GetFruits()
        {
            List<string> fruitList = new List<string>();

            fruitList.Add("banana");
            fruitList.Add("pear");
            fruitList.Add("apple");

            return GetValues(fruitList);
        }

        public string GetCarNames()
        {
            List<string> carNames = new List<string>();

            carNames.Add("skoda");
            carNames.Add("ford");
            carNames.Add("mazda");

            return GetValues(carNames);
        }

        public string GetValues(List<string> collection)
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

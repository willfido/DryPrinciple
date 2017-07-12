using System;
using System.Collections.Generic;
using System.Text;

namespace DryPrinciple.Example3.Oop
{
    class BaseExample<T>
    {
        public string GetList()
        {
            //If we want to extend functioanlity to the list it makes sense to farm this out.
            var list = Enum.GetNames(typeof(T));

            return GetValues(list);
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

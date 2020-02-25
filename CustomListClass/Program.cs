using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> customList = new CustomList<int>();
            customList.Add(8);
            customList.Add(6);
            customList.Add(7);
            customList.Add(5);
            customList.Add(3);
            customList.Add(0);
            customList.Add(9);
            customList.ToString();
            //customList.Remove(3);
            //customList.Add(4);
            //customList.Add(3);
            //customList.Add(5);
            //customList.Add(1);
            //customList.Add(11);
            //customList.Add(6);
            //customList.Add(10);
            //customList.Add(8);
            //customList.Add(2);
            //customList.Add(11);
            //int capacityVariable = customList.Capacity;
            //int intCheck1 = customList.Count;
            //int intCheck2 = customList.Count;
            //int intCheck3 = customList.Count;
            //int intCheck4 = customList.Capacity;
            Console.ReadLine();

            List<int> numbers = new List<int>();
            //numbers.Add(8);
            //numbers.Add(6);
            //numbers.Add(7);
            //numbers.Add(5);
            //numbers.Add(3);
            //numbers.Add(0);
            //numbers.Add(9);
            //numbers.ToString();

        }
    }
}

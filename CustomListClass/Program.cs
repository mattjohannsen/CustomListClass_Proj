﻿using System;
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
            customList.Add(4);
            Console.ReadLine();

            List<int> numbers = new List<int>();
            //numbers.Add(2);
            //numbers.Add(4);
            //numbers.Add(6);
            //numbers.Add(8);
            //numbers.Add(10);
        }
    }
}

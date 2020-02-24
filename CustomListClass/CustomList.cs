using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    public class CustomList <T>
    {
        //member variables
        private int count = 0;
        public int Count
        {
            get
            {
                return count;
            }
            set
            {
                count = value;
            }
        }
        private int capacity = 0;
        //public int Capacity
        //{
        //    get
        //    {
        //        return capacity;
        //    }
        //    set
        //    {
        //        capacity = value;
        //    }
        //}
        int numberOne = 4;
        CustomList<int> customList;
        public int[] theArray;


        //constructor  
        public CustomList()
        {
            count = 0;
            capacity = 4;
        }

        //member methods
        public void RunProgram()
        {
            CustomList<int> customList = new CustomList<int>();
            theArray = new int[4];
            theArray[0] = numberOne;
            Console.WriteLine();
            Console.WriteLine("This is the custom list program");
            customList.Add(theArray, numberOne);
            Console.WriteLine($"{theArray[0]}");
            //customList.Add(numberOne);

            //intArray[1] = 0;
            //intArray[2] = 0;
            //intArray[3] = 0;
            //intArray[0] = numberOne;


            //Console.WriteLine($"{intArray[0]}");
            //Console.WriteLine($"{count}");
            //customList.Add(intArray, numberOne);
            //Console.WriteLine($"{count}");
            //Console.WriteLine($"{intArray[0]}");
            //customList.GetCount(intArray);
            //Console.WriteLine($"This is your item: {numberOne}");
            //Console.WriteLine($"This is how many items are in the array:{count}");

        }


        public void Add(T[] inputArray, T itemToAdd)
        {
            inputArray[0] = itemToAdd;
            //customList.count ++;

            //increment count

            //item needs to land at next available index

            //check to make sure it persists

            //count == maxcapacity, we need to increase capacity and copy
        }

        public void GetCount(T[] inputArray)
        {
            int arrayCounter = 0;
            foreach (var item in inputArray)
            {
                arrayCounter++;
            }
            count = arrayCounter;
        }
    }
}

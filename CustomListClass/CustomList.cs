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
        CustomList<int> customList;
        private T[] theArray;
        private int count;
        public int Count
        {
            get
            {
                return count;
            }
        }
        private int capacity;
        public int Capacity { get; private set; }

        //constructor  
        public CustomList()
        {
            theArray = new T[4];
        }

        public void Add(T itemToAdd)
        {
            theArray[count] = itemToAdd;
            count++;
            //increment count - CHECK!!!

            //item needs to land at next available index - CHECK!!!

            //check to make sure it persists

            //count == maxcapacity, we need to increase capacity and copy
        }
    }
}

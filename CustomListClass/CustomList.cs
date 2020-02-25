using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    public class CustomList<T>
    {
        //member variables
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
        //Overloading method for setting up new Array with different Max capacity
        //public CustomList(int length)
        //{
        //    theArray = new T[length];
        //}
        public T this[int index]    // Indexer declaration  
        {
            // get and set accessors  
            get
            {
                return theArray[index];
            }
            set
            {
                theArray[index] = value;
            }
        }

        public void Add(T itemToAdd)
        {
            theArray[count] = itemToAdd;
            count++;

            //increment count - CHECK!!!

            //item needs to land at next available index -CHECK!


            //check to make sure it persists

            //count == maxcapacity, we need to increase capacity and copy
        }
        public void CheckArrayLength()
        {

        }

    }
}

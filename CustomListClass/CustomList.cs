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
        private int count;
        public int Count
        {
            get
            {
                return count;
            }
        }
        private int capacity;
        public int Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                capacity = value;
            }
        }
        //constructor  
        public CustomList()
        {
            theArray = new T[4];
            capacity = 4;
        }
        //Overloading method for setting up new Array with different Max capacity
        public CustomList(int length)
        {
            theArray = new T[length];
        }


        public void Add(T itemToAdd)
        {
            theArray[count] = itemToAdd;
            count++;
            if (capacity == count)
            {
                //We will need to create a new array
                IncreaseMaxCapacity();
            }
            //increment count - CHECK!!!
            //item needs to land at next available index -CHECK!
            //check to make sure it persists
            //count == maxcapacity, we need to increase capacity and copy
        }
        private void IncreaseMaxCapacity()
        {
            int newCount;
            newCount = (count * 2);
            T[] tempArray = new T[newCount];
            // Loop through array and assign values
            for (int i = 0; i < (count); i++)
            {
                tempArray[i] = theArray[i];
            }
            capacity = newCount;
            theArray = tempArray;
        }

    }
}

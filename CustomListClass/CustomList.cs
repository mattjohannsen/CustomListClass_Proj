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
            capacity = 4;
            theArray = new T[capacity];

        }
        //Overloading method for setting up new Array with different Max capacity
        //public CustomList(int length)
        //{
        //    capacity = length;
        //    theArray = new T[capacity];
        //}
        public void Remove(T itemToRemove)
        {
            int itemIndex = 0;

            bool isItemFound = IsItemFound(itemToRemove);

            if (isItemFound == true)
            {
                itemIndex = GetIndexOfItemToRemove(itemToRemove);
                CreateNewArray(itemIndex);
            }
        }
        public bool Compare(T firstValue, T secondValue)
        {
            if (firstValue.Equals(secondValue))
            {
                return true;
            }
            else
            {
                return false;
            }
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
            //check to make sure it persists CHECK!
            //count == maxcapacity, we need to increase capacity and copy - CHECK!
        }
        private void IncreaseMaxCapacity()
        {
            capacity = (capacity * 2);
            T[] tempArray = new T[capacity];
            // Loop through array and assign values
            for (int i = 0; i < (count); i++)
            {
                tempArray[i] = theArray[i];
            }
            theArray = tempArray;
        }
        private bool IsItemFound(T itemToRemove)
        {
            for (int i = 0; i < count; i++)
            {
                if (Compare(itemToRemove, theArray[i]))
                {
                    return true;
                }
            }
            return false;
        }
        private int GetIndexOfItemToRemove(T itemToRemove)
        {
            int itemIndex = 0;
            for (int i = 0; i < count; i++)
            {
                if (Compare(itemToRemove, theArray[i]))
                {
                    itemIndex = i;
                    break;
                }
            }
            return itemIndex;
        }

        private void CreateNewArray(int itemIndex)
        {
            T[] tempArray = new T[capacity];
            for (int i = 0; i < count; i++)
            {
                if (i < itemIndex)
                {
                    tempArray[i] = theArray[i];
                }
                else
                {
                    tempArray[i] = theArray[i + 1];
                }
            }
            count--;
            theArray = tempArray;
        }
    }
}

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
        //public CustomList(int inputCapacity, int inputCount, T[] inputArray)
        //{
        //    capacity = inputCapacity;
        //    count = inputCount;
        //    theArray = new T[capacity];
        //}

        public override string ToString()
        {
            string returnString = "";
            //BELOW IS THE START OF PERFECT CODE
            //string returnString = "";
            //for (int i = 0; i < count; i++)
            //{
            //    returnString += theArray[i].ToString();
            //}
            //return returnString;
            //ABOVE IS THE END OF PERFECT CODE
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                builder.Append(theArray[i].ToString());
                returnString = builder.ToString();
            }
            return returnString;
        }
        public void Remove(T itemToRemove)
        {
            int itemIndex = 0;

            bool isItemFound = IsItemFound(itemToRemove);

            if (isItemFound == true)
            {
                itemIndex = GetIndexOfItemToRemove(itemToRemove);
                CreateNewArrayForRemove(itemIndex);
            }
        }
        //public bool Compare(T firstValue, T secondValue)
        //{
        //    if (firstValue.Equals(secondValue))
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        public static CustomList<T> operator +(CustomList<T> listToAdd1, CustomList<T> listToAdd2)
        {
            T[] tempArray = new T[listToAdd1.capacity];
            CustomList<T> customList3 = new CustomList<T>();
            for (int i = 0; i < listToAdd1.Count; i++)
            {
                customList3.Add(customList3, listToAdd1[i]);
            }
            for (int i = 0; i < listToAdd2.Count; i++)
            {
                customList3.Add(customList3, listToAdd2[i]);
            }

            return customList3;
        }
        public void Add(T itemToAdd)
        {
            theArray[count] = itemToAdd;
            count++;
            if (capacity == count)
            {
                IncreaseMaxCapacity();
            }
        }
        public void Add(CustomList<T> inputList, T itemToAdd)
        {
            inputList.theArray[count] = itemToAdd;
            count++;
            if (capacity == count)
            {
                IncreaseMaxCapacity();
            }
        }
        private void IncreaseMaxCapacity()
        {
            capacity = (capacity * 2);
            T[] tempArray = new T[capacity];
            for (int i = 0; i < (count); i++)
            {
                tempArray[i] = theArray[i];
            }
            theArray = tempArray;
        }
        private void IncreaseMaxCapacity(CustomList<T> inputList)
        {
            inputList.capacity = (capacity * 2);
            T[] tempArray = new T[capacity];
            for (int i = 0; i < (count); i++)
            {
                tempArray[i] = inputList.theArray[i];
            }
            inputList.theArray = tempArray;
        }
        private bool IsItemFound(T itemToRemove)
        {
            for (int i = 0; i < count; i++)
            {
                if (theArray[i].Equals(itemToRemove))
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
                if (theArray[i].Equals(itemToRemove))
                {
                    itemIndex = i;
                    break;
                }
            }
            return itemIndex;
        }

        private void CreateNewArrayForRemove(int itemIndex)
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

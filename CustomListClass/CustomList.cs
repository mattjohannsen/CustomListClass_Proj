using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    public class CustomList<T> :IEnumerable
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
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return theArray[i];
            }
        }

        public override string ToString()
        {
            string returnString = "";
            //EXAMPLE OF NON STRINGBUILDER CODE BELOW
            //string returnString = "";
            //for (int i = 0; i < count; i++)
            //{
            //    returnString += theArray[i].ToString();
            //}
            //return returnString;
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
        public CustomList<T> Zip(CustomList<T> listToZip)
        {
            //int loopSize = (Count + listToZip.Count);
            int loopSize = Math.Max(Count, listToZip.Count);
            CustomList<T> customList3 = new CustomList<T>();
            for (int i = 0; i < loopSize; i++)
            {

                    if (i < (Count))
                    {
                        customList3.Add(theArray[i]);
                    }
                    if (i < listToZip.Count)
                    {
                        customList3.Add(listToZip.theArray[i]);
                    }

            }
            return customList3;
        }
        public static CustomList<T> operator -(CustomList<T> customList1, CustomList<T> customList2)
        {
            CustomList<T> itemsToSubtract = new CustomList<T>();
            CustomList<T> customList3 = new CustomList<T>();
            //Starting with my 2nd list LOOP through and see if any of the values are in the first list
            for (int i = 0; i < customList2.Count; i++)
            {
                //LOOP through the 1st list and see if any of the values are equal to the item in the outer loop 2nd list (customList2.theArray[i])
                for (int j = 0; j < customList1.Count; j++)
                {
                    //If the item from the 2nd List in the outer Loop equals the item in the 1st list inner loop, we add that value to an array of items to take out of the 1st list.
                    if (customList2.theArray[i].Equals(customList1.theArray[j]))
                    {
                        itemsToSubtract.Add(itemsToSubtract, customList1.theArray[j]);
                        //itemsToSubtract.theArray[j] = customList1.theArray[j];
                    }
                }
            }
            //Loop through temp array of removals and remove from first array
            for (int i = 0; i < itemsToSubtract.Count; i++)
            {
                customList1.Remove(itemsToSubtract[i]);
            }
            //Return new list
            customList3 = customList1;
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

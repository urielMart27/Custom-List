using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {
        //Member Variables (HAS A)
        private T[] items;
        public int capacity;
        public int count;

      

        //Constructor
        public CustomList()
        {
            //capacity = 
            capacity = 4;
            //count =
            count = 0;
            //items = 
            items = new T[capacity];
            
        }

        //Member Methods (CAN DO)
        public void Add(T item)
        {
            //'item' parameter should be added to internal 'items' array
            //if items array is at capacity, double capacity and create new array
            //transfer all items to new array
            
               if (count == capacity)
            {
                capacity *= 2;
                T[] newItems = new T[capacity];
                for (int i = 0; i < count; i++)
                {
                    newItems[i] = items[i];
                }
                items = newItems;
            }
            items[count] = item;
            count++;

            
        }
      
        
            

        public bool Remove(T item)
        {
            //If 'item' exists in the 'items' array, remove its first instance
            //Any items coming after the removed item should be shifted down so there is no empty index.
            //If 'item' was removed, return true. If no item was removed, return false.

            int index = Array.IndexOf(items, item, 0, count);
            if (index == -1)
            {
                return false;
            }

            for (int i = index; i < count - 1; i++)
            {
                items[i] = items[i + 1];
            }

            count--;
            return true;
            

        }

           public int Count
        {
            get { return count; }
        }

        public T this[int index]
        {
            get { return items[index]; }
        }
      

        public override string ToString()
        {
            //returns a single string that contains all items from array
            if (count == 0)
            {
                return " ";

            }

            StringBuilder result = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                result.Append(items[i]);
            }
            return result.ToString();
                
        }

        public static CustomList<T> operator +(CustomList<T> firstList, CustomList<T> secondList)
        {
            //returns a single CustomList<T> that contains all items from firstList and all items from secondList 
            CustomList<T> totalItems = new CustomList<T>();

            for (int i = 0; i < firstList.count;i++)
            {
                totalItems.Add(firstList[i]);
            }
            
            for (int i = 0; i < secondList.count;i++)
            {
                totalItems.Add(secondList[i]);
            }
            return totalItems;
           


          
        }

        public static CustomList<T> operator -(CustomList<T> firstList, CustomList<T> secondList)
        {
            //returns a single CustomList<T> with all items from firstList, EXCEPT any items that also appear in secondList
            CustomList<T> totalItems = new CustomList<T>();

            for (int i = 0; i < firstList.count; i++)
            {
                T currentItem = firstList[i];
                bool inSecondList = false;

                for (int j = 0; j < secondList.count; j++)
                {
                    if (EqualityComparer<T>.Default.Equals(currentItem, secondList[j]))
                    {
                        secondList.Remove(secondList[j]);
                        inSecondList = true;
                        break;
                    }
                }
                if (!inSecondList)
                {
                    totalItems.Add(currentItem);
                }
            }
            return totalItems;
        }


    }
}

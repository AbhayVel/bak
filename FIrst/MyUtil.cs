using System;
using System.Collections.Generic;
using System.Text;

namespace FIrst
{
    public delegate bool myFunc2<T>(T obj);
    public delegate bool myFuncInt(int a);
    public delegate bool myFuncString(string a);
    class MyUtil
    {
        
        public static int[] FilterInts (int[] array, myFuncInt x)
        {
            int[] newArray = new int[array.Length];
            int k = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (x(array[i]))
                    {
                    newArray[k] = array[i];
                    k++;
                    }
            }
            int[] finalAray = new int[k];
            for (int i = 0; i < array.Length; i++)
            {
                if (x(array[i]))
                {
                    newArray[k] = array[i];
                    k++;
                }
            }
            return newArray;
        } 

        public static string[] FilterStrings(string[] array, myFuncString x)
        {
            string[] newArray = new string[array.Length];
            int k = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (x(array[i]))
                {
                    newArray[k++] = array[i];
                }
            }
            return newArray;
        }
       
        public static IEnumerable<T> transform<T>(IEnumerable<T> array, myFunc2<T> y)
        {
            foreach (var item in array)
            {
                if (y(item))
                {
                    yield return item;
                }
            }
        }




    }
}

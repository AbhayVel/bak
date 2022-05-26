using System;
using System.Collections.Generic;
using System.Text;

namespace FIrst
{
    delegate bool FunAnyWhere<T>(T value);
    internal class Util
    {

        public static T[] Common<T>(T[] array, FunAnyWhere<T> func)
        {
            T[] result = new T[array.Length];
            int counter = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (func(array[i]))
                {
                    result[counter] = array[i];
                    counter++;
                }
            }
            return result;
        }

        public static int[] SortNumbers(int[] array, FunWhere func)
        {
            int[] result = new int[array.Length];
            int counter = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (func(array[i]))
                {
                    result[counter] = array[i];
                    counter++;
                }
            }
            
            return result;
        }
        public static string[] GetWhere(string[] array, FunWHereStr funct)
        {
            string[] result = new string[array.Length];
            int j = 0;
            for (int i = 0; i < array.Length; i = i + 1)
            {
                if (funct(array[i]))
                {
                    result[j] = array[i];
                    j = j + 1;
                }
            }
            return result;
        }


    }
}

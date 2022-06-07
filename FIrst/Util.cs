using System;
using System.Collections.Generic;
using System.Text;

namespace FIrst
{
    delegate bool FunAnyWhere<T>(T value);
    internal class Util
    {
        public static T[] ToMyArray<T>(IEnumerable<T> array)
        {
            int count = 0;

            foreach (var item in array)
            {
                count = count + 1;
            }
            T[] ts = new T[count];
            int i = 0;
            foreach (var item in array)
            {
                ts[i]=item;
                i = i + 1;
            }
            return ts;
        }

        public static List<T> ToMyList<T>(IEnumerable<T> array)
        {
             List<T> list = new List<T>();
            foreach (var item in array)
            {
               list.Add(item);
            }
            return list;
        }


        public static IEnumerable<T> Common<T>(IEnumerable<T> array, FunAnyWhere<T> func)
        {
           // List<T> result = new List<T>();
           foreach (var a in array)
             {
                if (func(a))
                {
                     yield return a;                     
                }
            }            
        }
        //public static T[] Common<T>(T[] array, FunAnyWhere<T> func)
        //{
        //    T[] result = new T[array.Length];
        //    int counter = 0;

        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        if (func(array[i]))
        //        {
        //            result[counter] = array[i];
        //            counter++;
        //        }
        //    }
        //    return result;
        //}

        //public static int[] SortNumbers(int[] array, FunWhere func)
        //{
        //    int[] result = new int[array.Length];
        //    int counter = 0;

        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        if (func(array[i]))
        //        {
        //            result[counter] = array[i];
        //            counter++;
        //        }
        //    }
            
        //    return result;
        //}
        //public static string[] GetWhere(string[] array, FunWHereStr funct)
        //{
        //    string[] result = new string[array.Length];
        //    int j = 0;
        //    for (int i = 0; i < array.Length; i = i + 1)
        //    {
        //        if (funct(array[i]))
        //        {
        //            result[j] = array[i];
        //            j = j + 1;
        //        }
        //    }
        //    return result;
        //}
            }
}

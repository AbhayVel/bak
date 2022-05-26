using System;

namespace FIrst
{


    //cutom data type 
   delegate bool FunWhere(int str); //Method signature->Datatype  //Deleget 

    //Hold method => with same siganature 
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] employee = new int[] { 1, 34, 56, 12, 78, 89, 29, 77, 66 };

            //int[] answer = SortNumbers(employee, 20);
            //int[] answer = CombinedFunc(employee, 20, "bottom");
            int[] answer = SortNumbers(employee, (x) => x > 30);  //call back method/annonomious method
                                                                  //int[] answer2 = SortNumbers2(employee, 80);
                                                                  // int[] answer2 = CombinedFunc(employee, 80, "top");
            int[] answer2 = SortNumbers(employee, (x) => x < 80);
            //int[] answer3 = SortNumbers3(employee, 2);
            int[] answer3 = CombinedFunc(employee, 2, "divisor");

            //Print(answer);
            //Print(answer2);
            Console.WriteLine("answer 1:");
            Print(answer);
            Console.WriteLine("answer 2:");
            Print(answer2);
            Console.WriteLine("answer 3:");
            Print(answer3);


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
            int[] result2 = new int[counter];
            int counter2 = 0;
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] != 0)
                {
                    result2[counter2] = result[i];
                    counter2++;
                }
            }
            return result2;
        }

        public static int[] SortNumbers2(int[] array, int upperLimit)
        {
            int[] result = new int[array.Length];
            int counter = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] <= upperLimit)
                {
                    result[counter] = array[i];
                    counter++;
                }
            }
            int[] result2 = new int[counter];
            int counter2 = 0;
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] != 0)
                {
                    result2[counter2] = result[i];
                    counter2++;
                }
            }
            return result2;
        }

        public static int[] SortNumbers3(int[] array, int divisor)
        {
            int[] result = new int[array.Length];
            int counter = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % divisor == 0)
                {
                    result[counter] = array[i];
                    counter++;
                }
            }
            int[] result2 = new int[counter];
            int counter2 = 0;
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] != 0)
                {
                    result2[counter2] = result[i];
                    counter2++;
                }
            }
            return result2;
        }

        public static int[] CombinedFunc(int[] array, int number, string condition)
        {
            int[] result = new int[array.Length];
            int counter = 0;

            if (condition.Equals("top", StringComparison.OrdinalIgnoreCase))
            {

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] <= number)
                    {
                        result[counter] = array[i];
                        counter++;
                    }
                }

                int[] result2 = new int[counter];
                int counter2 = 0;

                for (int i = 0; i < result.Length; i++)
                {
                    if (result[i] != 0)
                    {
                        result2[counter2] = result[i];
                        counter2++;
                    }
                }
                return result2;
            }

            else if (condition.Equals("bottom", StringComparison.OrdinalIgnoreCase))
            {

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] >= number)
                    {
                        result[counter] = array[i];
                        counter++;
                    }
                }

                int[] result2 = new int[counter];
                int counter2 = 0;

                for (int i = 0; i < result.Length; i++)
                {
                    if (result[i] != 0)
                    {
                        result2[counter2] = result[i];
                        counter2++;
                    }
                }
                return result2;
            }
            else if (condition.Equals("divisor", StringComparison.OrdinalIgnoreCase))
            {

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % number == 0)
                    {
                        result[counter] = array[i];
                        counter++;
                    }
                }

                int[] result2 = new int[counter];
                int counter2 = 0;

                for (int i = 0; i < result.Length; i++)
                {
                    if (result[i] != 0)
                    {
                        result2[counter2] = result[i];
                        counter2++;
                    }
                }
                return result2;
            } else
            {
                return null;
            }

        }

        private static void Print(int[] employees)
        {
            for (int i = 0; i < employees.Length; i = i + 1)
            {
                Console.WriteLine(employees[i]);
            }
        }
    }
}

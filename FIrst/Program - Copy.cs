using System;

namespace FIrst
{


    //cutom data type 
    delegate bool FunWHereStr(string str); //Method signature->Datatype 

    //Hold method => with same siganature 
    internal class ProgramData
    {
        static void MainData(string[] args)
        {
            //Datatype variableName=Hold intgeger value;
            int a = 0;

            //Datattype variable =hold string value 
            string na = "aa";
            //w/s 
            //String 
            //number 
            //boolean 
            //array/collection  
            //dateTIme 

            string str = "Bak al";
            var d = str.StartsWith("s");

            var employees = new string[] { "Bak", "John", "jhon", "Abhay", "Mac", "Kally", "Bal" };

            //Annonomious Method
            //var resultA = GetWhere(employees, (x)=>x.StartsWith("A"));
            //var resultB = GetWhere(employees, (x) => x.StartsWith("B"));

            //Print(resultA);
            //Print(resultB);

            var resultk = GetWhere(employees, Condition);
            var resulty = Util.Common(employees, (x) => x.StartsWith("y"));

            Print(resultk);
            // Print(resulty);


            Console.WriteLine("Hello World!");
        }


        static bool Condition(string str)
        {
            return str.StartsWith("A");
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

        public static string[] XXX(string[] employees, string val, string condition)
        {
            string[] result = new string[employees.Length];
            int j = 0;
            for (int i = 0; i < employees.Length; i = i + 1)
            {
                if (condition.Equals("Contains", StringComparison.OrdinalIgnoreCase))
                {
                    if (employees[i].Contains(val))
                    {
                        result[j] = employees[i];
                        j = j + 1;
                    }
                }
                else if (condition.Equals("StartsWith", StringComparison.OrdinalIgnoreCase))
                {
                    if (employees[i].StartsWith(val))
                    {
                        result[j] = employees[i];
                        j = j + 1;
                    }
                }
                else if (condition.Equals("EndsWith", StringComparison.OrdinalIgnoreCase))
                {
                    if (employees[i].EndsWith(val))
                    {
                        result[j] = employees[i];
                        j = j + 1;
                    }
                }
            }
            return result;
        }




        public static string[] GetContains(string[] employees, string val)
        {
            string[] result = new string[employees.Length];
            int j = 0;
            for (int i = 0; i < employees.Length; i = i + 1)
            {
                if (employees[i].Contains(val))
                {
                    result[j] = employees[i];
                    j = j + 1;
                }
            }
            return result;
        }

        public static string[] GetEndWith(string[] employees, string val)
        {
            string[] result = new string[employees.Length];
            int j = 0;
            for (int i = 0; i < employees.Length; i = i + 1)
            {
                if (employees[i].EndsWith(val))
                {
                    result[j] = employees[i];
                    j = j + 1;
                }
            }
            return result;
        }

        public static string[] GetStartWith(string[] employees, string val)
        {
            string[] result = new string[employees.Length];
            int j = 0;
            for (int i = 0; i < employees.Length; i = i + 1)
            {
                if (employees[i].StartsWith(val))
                {
                    result[j] = employees[i];
                    j = j + 1;
                }
            }
            return result;
        }

        public static void Print(string[] employees)
        {
            for (int i = 0; i < employees.Length; i = i + 1)
            {
                Console.WriteLine(employees[i]);
            }
        }

    }
}

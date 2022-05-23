using System;

namespace FIrst
{

    delegate bool Funct(string str);
    internal class Program
    {
        static void Main(string[] args)
        {
            //w/s 
            //String 
            //number 
            //boolean 
            //array/collection  
            //dateTIme 

            string str = "Bak al";
          var d=  str.StartsWith("s");

            var employees =new string[] { "Bak", "John", "jhon", "Abhay", "Mac", "Kally", "Bal" };

            //Annonomious Method
            var resultA = GetWhere(employees, (x)=>x.StartsWith("A"));
            var resultB = GetWhere(employees, (x) => x.StartsWith("B"));

            Print(resultA);
            Print(resultB);

            var resultk= GetWhere(employees, (x) => x.Contains("k"));
            var resulty  = GetWhere(employees, (x) => x.EndsWith("y"));

            Print(resultk);
            Print(resulty);


            Console.WriteLine("Hello World!");
        }


        static bool Condition(string str)
        {
            return str.EndsWith("a");
        }

        public static string[] GetWhere(string[] employees, Funct funct)
        {
            string[] result = new string[employees.Length];
            int j = 0;
            for (int i = 0; i < employees.Length; i = i + 1)
            {
                if (funct(employees[i]))
                {
                    result[j] = employees[i];
                    j = j + 1;
                }
            }
            return result;
        }
         
            public static string[] XXX(string[] employees, string val,string condition)
        {
            string[] result = new string[employees.Length];
            int j = 0;
            for (int i = 0; i < employees.Length; i = i + 1)
            {
                if(condition.Equals("Contains", StringComparison.OrdinalIgnoreCase))
                {
                    if (employees[i].Contains(val))
                    {
                        result[j] = employees[i];
                        j = j + 1;
                    }
                } else if (condition.Equals("StartsWith", StringComparison.OrdinalIgnoreCase))
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
            string[] result= new string[employees.Length];
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

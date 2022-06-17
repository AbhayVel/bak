using System;
using System.Collections.Generic;
using System.Text;

namespace FIrst
{
    class Program_copy_June_9
    {
        static void Main2(string[] x)
        {

            int i = 0;
            if (x.Length > 0) int.TryParse(x[0], out i);

            var employees = new Employee[] {
            new Employee{ Id=1, Name="ABhay",Salary=120000},
             new Employee{ Id=2, Name="Bak",Salary=120000},
              new Employee{ Id=3, Name="John",Salary=120000},
               new Employee{ Id=4, Name="Marry",Salary=120000},
                new Employee{ Id=5, Name="Jhon",Salary=120000},

            };


            string str = System.IO.File.ReadAllText("../../../temp.html");


            str = str.Replace("@name", employees[i].Name);
            str = str.Replace("@id", employees[i].Id.ToString());
            str = str.Replace("@salary", employees[i].Salary.ToString());

            Console.WriteLine(str);

            System.IO.File.WriteAllText("../../../index.html", str);

        }


    }
}

   

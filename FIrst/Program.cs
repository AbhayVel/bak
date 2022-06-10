using System;
using System.Collections.Generic;
using System.Linq;

namespace FIrst
{


    //cutom data type 

    //Hold method => with same siganature 
    internal class Program
    {
        static void Main(string[] x)
        {

             
            var route = "e";
            int i = 0;
            if (x.Length > 1) int.TryParse(x[1], out i);
            if (x.Length > 0) route = x[0];

            if (route.Equals("p"))
            {
                PersonController person= new PersonController();
                person.Index(i);
            }
            else
            {
                EmployeeController employeeController = new EmployeeController();
                employeeController.Index(i);
            }


        }


    }
}

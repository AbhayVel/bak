using System;
using System.Collections.Generic;
using System.Linq;

namespace FIrst
{


    //cutom data type 

    //Hold method => with same siganature 
    internal class Program
    {

        static void Main(string[] args)
        {
            string action="Index";
            string controller = "Person"+"Controller";
            if (args.Length > 0)
            {
                var path = args[0];
                string[] pathArray = path.Split('/');
                controller = pathArray[0] + "Controller";
                if (pathArray.Length > 1)
                {
                    action = pathArray[1];
                }
            }
            var p = new Program();
            var assembly= p.GetType().Assembly;
             

            //var route = "e";
            //int i = 0;
            //if (x.Length > 1) int.TryParse(x[1], out i);
            //if (x.Length > 0) route = x[0];

            //if (route.Equals("p"))
            //{
            //    PersonController person= new PersonController();
            //    person.Index(i);
            //}
            //else if (route.Equals("u"))
            //{
            //    UserController user = new UserController();
            //    user.Index(i);
            //}
            //else
            //{
            //    EmployeeController employeeController = new EmployeeController();
            //    employeeController.Index(i);
            //}


        }


    }
}

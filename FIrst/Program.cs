using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

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
            string controllerName = "Person";
            if (args.Length > 0)
            {
                var path = args[0];
                string[] pathArray = path.Split('/');
                controller = pathArray[0] + "Controller";
                controllerName = pathArray[0];
                if (pathArray.Length > 1)
                {
                    action = pathArray[1];
                }
            }
            Console.WriteLine(controller);
            Console.WriteLine(action);
            var p = new Program();
            var assembly = p.GetType().Assembly;
            Type type = assembly.DefinedTypes.FirstOrDefault(x => x.Name.Equals(controller));
            var controllerObject = Activator.CreateInstance(type);
            MethodInfo method = type.GetMethod(action);
            var result=    method.Invoke(controllerObject, new object[] { 0 });
            ViewResult vr= new ViewResult();
            vr.Execute(controllerName,action,result);
            //var route = "e";
            //int i = 0;
            //if (x.Length > 1) int.TryParse(x[1], out i);
            //if (x.Length > 0) route = x[0];

            //if (route.Equals("p"))
            //{
            //    PersonController person = new PersonController();
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

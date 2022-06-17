using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace FIrst
{
    internal class ViewResult 
    {
        public void Execute(string controllerName,string actionName,Object obj)
        {
            string str = System.IO.File.ReadAllText($"../../../Views/{controllerName}/{actionName}.html");
            //Model Binder 

            Type type = obj.GetType();
            PropertyInfo[] pi = type.GetProperties();
            foreach(PropertyInfo pi2 in pi)
            {
               str = str.Replace("@"+ pi2.Name.ToLower(), pi2.GetValue(obj).ToString());
            }

            Console.WriteLine(str);

             
             System.IO.File.WriteAllText("../../../index.html", str);
        }
    }
}

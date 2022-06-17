using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace FIrst
{
    public class EmployeeController
    {

        public Employee Index(int i)
        {
            var employees = new Employee[] {
            new Employee{ Id=1, Name="ABhay",Salary=120000},
             new Employee{ Id=2, Name="Bak",Salary=120000},
              new Employee{ Id=3, Name="John",Salary=120000},
               new Employee{ Id=4, Name="Marry",Salary=120000},
                new Employee{ Id=5, Name="Jhon",Salary=120000},

            };
           
            return employees[i];
            //string str = System.IO.File.ReadAllText("../../../temp.html");


            //str = str.Replace("@name", employees[i].Name);
            //str = str.Replace("@id", employees[i].Id.ToString());
            //str = str.Replace("@salary", employees[i].Salary.ToString());

            //Console.WriteLine(str);

            //System.IO.File.WriteAllText("../../../index.html", str);
        }

        public Employee GetEmployee(int i) //Action
        {
            Employee employee = new Employee();
            employee.Id = 13;
            employee.Name = "New Employee Test";
            employee.Salary = 40000;

            return employee;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace FIrst
{
    public class UserController
    {

        public Users Index(int i)
        {
            var employees = new Users[] {
            new Users{ Id=1, Name="ABhay",Salary=120000},
             new Users{ Id=2, Name="Bak",Salary=120000},
              new Users{ Id=3, Name="John",Salary=120000},
               new Users{ Id=4, Name="Marry",Salary=120000},
                new Users{ Id=5, Name="Jhon",Salary=120000},

            };

            return employees[i];
            //string str = System.IO.File.ReadAllText("../../../tempUser.html");


            //str = str.Replace("@name", employees[i].Name);
            //str = str.Replace("@id", employees[i].Id.ToString());
            //str = str.Replace("@salary", employees[i].Salary.ToString());

            //Console.WriteLine(str);

            //System.IO.File.WriteAllText("../../../index.html", str);
        }
    }
}

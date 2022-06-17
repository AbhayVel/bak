using System;
using System.Collections.Generic;
using System.Text;

namespace FIrst
{
    public class PersonController //Controller
    {

        public Person Index(int i) //Action
        {
            var employees = new Person[] {
            new Person{ Id=1, Name="Bak",Salary=120000},
             new Person{ Id=2, Name="Abhay",Salary=120000},
              new Person{ Id=3, Name="John",Salary=120000},
               new Person{ Id=4, Name="Marry",Salary=120000},
                new Person{ Id=5, Name="Jhon",Salary=120000},

            };

            return employees[i];            
        }

        public Person EditPerson(int i) //Action
        {
            var p = new Person { Id = 5, Name = "Jhon", Salary = 120000 };
            return p;
        }

    }

}
using Microsoft.AspNetCore.Mvc;
using StudentMS.Entities;
using System.Collections.Generic;
using System.Linq;

namespace StudentMS.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index(string columnName, string orderBY)
        {
            var lstStuent = GetStudentList();
            if("id".Equals(columnName, System.StringComparison.CurrentCultureIgnoreCase))
            {
                lstStuent = lstStuent.OrderBy(x => x.Id).ToList();
            }
            if ("FirstName".Equals(columnName, System.StringComparison.CurrentCultureIgnoreCase))
            {
                lstStuent = lstStuent.OrderBy(x => x.FirstName).ToList();
            }

            if ("LastName".Equals(columnName, System.StringComparison.CurrentCultureIgnoreCase))
            {
                lstStuent = lstStuent.OrderBy(x => x.LastName).ToList();
            }

            return View(lstStuent);
        }


       List<Student> GetStudentList()
        {
            List<Student> lstStuent = new List<Student>();
            lstStuent.Add(new Student
            {
                Id = 2,
                FirstName = "Abhay",
                LastName = "Velankar.aa",
                Class = ".net",
                Fees = 200000,
                Age = 20
            });

            lstStuent.Add(new Student
            {
                Id = 1,
                FirstName = "Bak",
                LastName = "Al",
                Class = "java",
                Fees = 300000,
                Age = 19
            });

            lstStuent.Add(new Student
            {
                Id = 3,
                FirstName = "AJohn",
                LastName = "K",
                Class = "Type",
                Fees = 350000,
                Age = 30
            });


            lstStuent.Add(new Student
            {
                Id = 4,
                FirstName = "John",
                LastName = "PK",
                Class = "Type",
                Fees = 350000,
                Age = 30
            });

            return lstStuent;
        }
    }
}

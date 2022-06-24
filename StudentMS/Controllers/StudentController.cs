using Microsoft.AspNetCore.Mvc;
using StudentMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentMS.Controllers
{
    public class StudentController : Controller
    {
        //columnName for orderBY
        public IActionResult Index(string Id, string FirstName, string LastName, string columnName = "FirstName", string orderBy = "asc")
        {
            var lstStuent = GetStudentList();

            if (!string.IsNullOrEmpty(Id))
            {
                int id = 0;
                bool isParsed = int.TryParse(Id, out id);
                if (isParsed)
                {
                    lstStuent= lstStuent.Where(x=>x.Id==id).ToList(); 
                }
            }

            if (!string.IsNullOrEmpty(FirstName))
            {               
                    lstStuent = lstStuent.Where(x => x.FirstName.ToLower().Contains(FirstName.ToLower())).ToList();
             }

            if (!string.IsNullOrEmpty(LastName))
            {
                lstStuent = lstStuent.Where(x => x.LastName.ToLower().Contains(LastName.ToLower())).ToList();
            }


            if ("id".Equals(columnName, System.StringComparison.CurrentCultureIgnoreCase))
            {
                if ("asc".Equals(orderBy, StringComparison.CurrentCultureIgnoreCase))
                {
                     
                    lstStuent = lstStuent.OrderBy(x => x.Id).ToList();
                } else
                {
                    lstStuent = lstStuent.OrderByDescending(x => x.Id).ToList();
                }
            }
            if ("FirstName".Equals(columnName, System.StringComparison.CurrentCultureIgnoreCase))
            {
                if ("asc".Equals(orderBy, StringComparison.CurrentCultureIgnoreCase))
                {
                    lstStuent = lstStuent.OrderBy(x => x.FirstName).ToList();
                } else
                {
                    lstStuent = lstStuent.OrderByDescending(x => x.FirstName).ToList();
                }
            }

            if ("LastName".Equals(columnName, System.StringComparison.CurrentCultureIgnoreCase))
            {
                if ("asc".Equals(orderBy, StringComparison.CurrentCultureIgnoreCase))
                {
                    lstStuent = lstStuent.OrderBy(x => x.LastName).ToList();
                } else
                {
                    lstStuent = lstStuent.OrderByDescending(x => x.LastName).ToList();
                }
            }

            //if ("asc".Equals(orderBy, StringComparison.CurrentCultureIgnoreCase))
            //{
            //    ViewBag.OrderBy = "desc";
            //}
            //else
            //{
            //    ViewBag.OrderBy = "asc";
            //}
            ViewBag.OrderBy = orderBy;
            ViewBag.ColumnName = columnName;
            ViewBag.Id = Id;
            ViewBag.FirstName = FirstName;
            ViewBag.LastName = LastName;
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

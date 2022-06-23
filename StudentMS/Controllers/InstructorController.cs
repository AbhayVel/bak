using Microsoft.AspNetCore.Mvc;
using StudentMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentMS.Controllers
{
    public class InstructorController : Controller
    {
        public IActionResult Index(string columnName, string orderBy)
        {
            var instructorsList = GetInstructorsList();
            if("Id".Equals(columnName, System.StringComparison.CurrentCultureIgnoreCase))
            {
                instructorsList = instructorsList.OrderBy(x => x.Id).ToList();
            }

            if ("FirstName".Equals(columnName, System.StringComparison.CurrentCultureIgnoreCase))
            {
                instructorsList = instructorsList.OrderBy(x => x.FirstName).ToList();
            }

            if ("LastName".Equals(columnName, System.StringComparison.CurrentCultureIgnoreCase))
            {
                instructorsList = instructorsList.OrderBy(x => x.LastName).ToList();
            }

            if ("Department".Equals(columnName, System.StringComparison.CurrentCultureIgnoreCase))
            {
                instructorsList = instructorsList.OrderBy(x => x.Department).ToList();
            }

            if ("Email".Equals(columnName, System.StringComparison.CurrentCultureIgnoreCase))
            {
                instructorsList = instructorsList.OrderBy(x => x.Email).ToList();
            }

            if ("Salary".Equals(columnName, System.StringComparison.CurrentCultureIgnoreCase))
            {
                instructorsList = instructorsList.OrderBy(x => x.Salary).ToList();
            }
            return View(instructorsList);
        }

        List<Instructor> GetInstructorsList()
        {
            List<Instructor> instructorsList = new List<Instructor>();
            instructorsList.Add(new Instructor
            {
                Id = 234,
                FirstName = "Halem",
                LastName = "Simmer",
                Department = "Mathematics",
                Email = "halem@xyzuniversity.edu",
                Salary = 123455
            });

            instructorsList.Add(new Instructor
            {
                Id = 841,
                FirstName = "Zurab",
                LastName = "Samaria",
                Department = "Physics",
                Email = "zurab@xyzuniversity.edu",
                Salary = 72305
            });

            instructorsList.Add(new Instructor
            {
                Id = 9123,
                FirstName = "Manisa",
                LastName = "Kamar",
                Department = "Biology",
                Email = "manisa@xyzuniversity.edu",
                Salary = 329543
            });

            instructorsList.Add(new Instructor
            {
                Id = 8723,
                FirstName = "Perama",
                LastName = "Aliminda",
                Department = "History",
                Email = "perama@xyzuniversity.edu",
                Salary = 883244
            });

            return instructorsList;
        }

    }
}

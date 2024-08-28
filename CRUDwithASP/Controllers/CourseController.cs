using CRUDwithASP.Models;
using CRUDwithASP.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace CRUDwithASP.Controllers
{
    public class CourseController : Controller
    {
        DatabaseEntities dbcontext = new DatabaseEntities();

        public IActionResult CheckDegree(int degree)
        {
            if (degree >= 50 & degree <= 100)
            {
                return Json(true);
            }
            else
            {
                return Json(false);
            }
        }

        //Course/GetAllCourses
        public IActionResult GetAllCourses()
        {

            var courses = dbcontext.Courses.ToList();
            return View(courses);
        }
        [HttpGet]
        public IActionResult Create()
        {

            var coursename = dbcontext.Departments.Select(a => new DepartmentMV { DeptID = a.Id, Name = a.Name }).ToList();
            return View(coursename);
        }
        [HttpPost]
        public IActionResult Create(Course course)
        {
            if (course != null)
            {
                dbcontext.Courses.Add(course);
                dbcontext.SaveChanges();
                return RedirectToAction("GetAllCourses");

            }
            return RedirectToAction("GetAllCourses");
        }

        [HttpGet]
        public IActionResult Edit(int id)

        {
            EditVM editVM = new EditVM();
            var course = dbcontext.Courses.FirstOrDefault(a => a.Id == id);

            editVM.ID = course.Id;
            editVM.Degree = course.degree;
            editVM.mindDegree = course.mindDegree;
            editVM.Name = course.Name;
            editVM.departmentID = course.DepartmentId;
            editVM.Departments = dbcontext.Departments.Select(a => new DepartmentMV { DeptID = a.Id, Name = a.Name }).ToList();


            return View(editVM);
        }

        public IActionResult Edit(Course course, int id)
        {
            if (course.Id == id)
            {
                if (ModelState.IsValid)
                {
                    dbcontext.Courses.Update(course);
                    dbcontext.SaveChanges();

                    return RedirectToAction("GetAllCourses");
                }
            }

            EditVM editVM = new EditVM();


            editVM.ID = course.Id;
            editVM.Degree = course.degree;
            editVM.mindDegree = course.mindDegree;
            editVM.Name = course.Name;
            editVM.departmentID = course.DepartmentId;
            editVM.Departments = dbcontext.Departments.Select(a => new DepartmentMV { DeptID = a.Id, Name = a.Name }).ToList();

            return View(editVM);

        }
        public IActionResult Delete(int id)
        {
            var deletedtem = dbcontext.Courses.FirstOrDefault(c => c.Id == id);
            if (deletedtem != null)
            {
                dbcontext.Courses.Remove(deletedtem);
                dbcontext.SaveChanges();
            }

            return RedirectToAction("GetAllCourses"); ;
        }
    }
}

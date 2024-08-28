using CRUDwithASP.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUDwithASP.Controllers
{
    public class InstructorController : Controller
    {
        DatabaseEntities dbcontext = new DatabaseEntities();

        //Instructor/Index
        public IActionResult Index()
        {
            return View(dbcontext.Instructors.ToList());
        }

        //Instructor/InstructorDetails
        public IActionResult InstructorDetails(int id)
        {
            var inst = dbcontext.Instructors.Find(id);
            return View(inst);
        }

        //Instructor/InstructorDetailsPartial
        public IActionResult InstructorDetailsPartial(int id)
        {
            var inst = dbcontext.Instructors.Find(id);
            return PartialView("_InstructorDetailsPartial", inst);
        }
        //Instructor/GetDepartments
        public IActionResult GetDepartments ()
        {
            var depts = dbcontext.Departments.ToList();
            return View(depts); 
        }
        //Instructor/GetInstructors
        public IActionResult GetInstructors(int DeptId)
        {
            var inst = dbcontext.Instructors.Where(a =>a.DepartmentID == DeptId).ToList();
            return Json(inst);
        }

    }
}

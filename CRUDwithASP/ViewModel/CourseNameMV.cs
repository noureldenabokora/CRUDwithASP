using System.ComponentModel.DataAnnotations;

namespace CRUDwithASP.ViewModel
{
    public class CourseNameMV
    {
        public int CourseID { get; set; }

        public string Name { get; set; }

    }

    public class DepartmentMV
    {
        public int DeptID { get; set; }

   
        public string Name { get; set; }
    }

    public class ListVM 
    {
        public List<CourseNameMV> courseNameMVs { get; set; }

        public List<DepartmentMV> departmentMVs { get; set; }
    }
}

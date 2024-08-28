using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace CRUDwithASP.ViewModel
{
    public class EditVM
    {
        public int ID { get; set; }
        [Remote("CheckDegree", "Course", ErrorMessage = " Degree Must Be bigger than 50 and lower than 100")]
        public int  Degree { get; set; }
        [Range(0, 100,ErrorMessage = "Degree Must be in  0 and 100")]
        public int mindDegree { get; set; }

        [Required(ErrorMessage = "Name Must Be Added")]
        [MaxLength(50, ErrorMessage = "Name IS too Long ")]
        [MinLength(5, ErrorMessage = "Name is too Short")]
        public string Name { get; set; }

        public List<DepartmentMV> Departments { get; set; }
        public int departmentID { get; set; }

    }
}

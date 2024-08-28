using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace CRUDwithASP.Models
{
    public class Course : BaseEntites
    {
        [Remote("CheckDegree", "Course",ErrorMessage =" Degree Must Be bigger than 50 and lower than 100")]
        public int degree { get; set; }
        [Range(0,100,ErrorMessage ="Degree Must be in  0 and 100")]
        public int mindDegree { get; set; }
        public int DepartmentId { get; set; }

        public virtual Department department { get; set; }

        public virtual ICollection<Instructor> instructors { get; set; }

        public virtual ICollection<CourseResult> CourseResults { get; set; }


    }
}

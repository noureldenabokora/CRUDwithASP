namespace CRUDwithASP.Models
{
    public class Trainne : BaseEntites
    {
        public string ImageURL { get; set; }
        public string Address { get; set; }

        public int Grade { get; set; }
        public int DepartmentID { get; set; }

        public virtual Department department { get; set; }

        public virtual ICollection<CourseResult> CourseResults { get; set; }

    }
}

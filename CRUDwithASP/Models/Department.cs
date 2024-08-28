namespace CRUDwithASP.Models
{
    public class Department : BaseEntites
    {

        public string manager { get; set; }

        public virtual ICollection<Instructor> departments { get; set; }

        public virtual ICollection<Course> courses { get; set; }

        public virtual ICollection<Trainne> trainnesses { get; set; }
    }
}

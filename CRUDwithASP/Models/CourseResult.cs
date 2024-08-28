namespace CRUDwithASP.Models
{
    public class CourseResult
    {
        public int Id { get; set; }
        public int Degree { get; set; }

        public int CourseID { get; set; }
        public int TraineeID { get; set; }

        public virtual Trainne Trainne { get; set; }

        public virtual Course Course { get; set; }
    }
}

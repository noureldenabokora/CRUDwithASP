using System.ComponentModel.DataAnnotations;

namespace CRUDwithASP.Models
{
    public class Instructor : BaseEntites
    {
      //  [RegularExpression(@"\w*\.(png | jpg)", ErrorMessage = "image extension must be JPG or PNG")]
        public string ImageURL { get; set; }

  //      [MaxLength(100, ErrorMessage = "address maxlenght 100 character ")]
//        [MinLength(5, ErrorMessage = "address must be at least 5 Character")]
        public string Address { get; set; }

        public int DepartmentID { get; set; }
        public int CourseID { get; set; }

        public virtual Department department { get; set; }
        public virtual Course course { get; set; }
    }
}

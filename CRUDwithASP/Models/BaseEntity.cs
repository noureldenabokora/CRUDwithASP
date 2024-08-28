using System.ComponentModel.DataAnnotations;

namespace CRUDwithASP.Models
{

    public class BaseEntites
    {
        public int Id { get; set; }
        //[Required(ErrorMessage = "must add name")]
        // [MaxLength(100, ErrorMessage = "name must be at least 5 Character")]
        //[MinLength(5, ErrorMessage = "name maxlenght 100 character")]
        // [NameUnique]

        [Required(ErrorMessage = "Name Must Be Added")]
        [MaxLength(50, ErrorMessage = "Name IS too Long ")]
        [MinLength(5, ErrorMessage = "Name is too Short")]
        public string Name { get; set; }


    }
}

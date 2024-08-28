using System.ComponentModel.DataAnnotations;

namespace CRUDwithASP.Models
{
    public class Login
    {
        [DataType(DataType.EmailAddress)]
        public string UserEmail { get; set; }
        [DataType(DataType.Password)]
        public string UserPassword { get; set; }

    }
}

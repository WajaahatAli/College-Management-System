using System.ComponentModel.DataAnnotations;

namespace College_Management_System.Models
{



    public class Attributes
    {

        [Required(ErrorMessage = "First Name is required")]
        public string FirstName { get; set; } = "";

        [Required(ErrorMessage = "last name is required")]


        public string LastName { get; set; } = "";

        [Required(ErrorMessage = "Age is required")]
        public int age { get; set; }

        public string School { get; set; }
        [Required(ErrorMessage = "Gender is required")]
        public string gender { get; set; }
        [Required(ErrorMessage = " Date of birth is required")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }


    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EntAppSecond.Models
{
    public class Student
    {

        [Required(ErrorMessage = "Please Enter a Student ID")]
        [RegularExpression(@"(s|S)\d{7}", ErrorMessage = "Not an valid Student ID")]
        public string StudentID { get; set; } = "";

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Please enter a First Name")]
        [MinLength (2, ErrorMessage = "First Name must contain at least two characters")]
        public string FirstName { get; set; } = "";

        [Required]
        [DisplayName("Second Name")]
        [MinLength(3, ErrorMessage = "First Name must contain at least three characters")]
        public string SecondName { get; set; } = "";

    }
}

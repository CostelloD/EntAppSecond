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


        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [RegularExpression(@"^[1-9][0-9]*$", ErrorMessage = "Number of Modules cannot be Zero")]
        public int NumberOfModules { get; set; }


        [Required]
        [RegularExpression(@"^[5-9][0-9]|1[0-9][0 - 9]|2[0-4][0-9]|250", ErrorMessage ="Height must be between 50 and 200 cm") ]
        public int Height { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string EmailConfirm { get; set; }

        [Required]
        [Display(Name ="Car Registration (Connaught)")]
        [RegularExpression(@"^(1[0-9][1-2]|[0-9][0-9])((RN)|(rn)|(MO)|(mo)|(LM)|(lm)|G|g|(SO)|(so))\d{1,6}", 
            ErrorMessage = "Not a valid Registration number - please check and try again")]
        public string CarRegister { get; set; }


        [Required]
        [Display(Name = "Mobile Phone Number")]
        [RegularExpression(@"^(\D?)(\d{2,5})?\D?\d{2,3}(\D?)(\D?)\d{7}", ErrorMessage = "Not a Valid Mobile Number, please check and try again")]
        public string Phone { get; set; }
    }
}

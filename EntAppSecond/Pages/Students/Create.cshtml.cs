using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntAppSecond.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EntAppSecond.Pages.Students
{
    public class CreateModel : PageModel
    {


        [BindProperty]
        public Student Student { get; set; }

        public string Message { get; set; }

        public void OnPost()
        {
            if (Student.Email == Student.EmailConfirm)
            {
                Message = "";
            }

            else
            {
                Message = "Email does not Match, Please enter again";
            }
        }

        public void OnGet()
        {

        }
    }
}
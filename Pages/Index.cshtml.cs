using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using StudentsAndCoursesInClass.Models;
using StudentsAndCoursesInClass.Operations;

namespace StudentsAndCoursesInClass.Pages
{
    [BindProperties]
    public class IndexModel : PageModel
    {

        //This is the student Base Class
        public Student student { get; set; }

        public string something { get; set; }
        public int? StudentSelected { get; set; }

        public bool IsFirstLoad { get; set; } = false;

        public IndexModel()
        {
            // student = new Student();
        }
        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost()
        {

            IsFirstLoad = true;

            student = Factory.GetAStudent(StudentSelected);

            return Page();
        }
    }
}
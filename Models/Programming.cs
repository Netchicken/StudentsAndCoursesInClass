using StudentsAndCoursesInClass.Operations;

namespace StudentsAndCoursesInClass.Models
{
    public class Programming : Student
    {

        public bool HasLaptop { get; set; }
        public bool IsEnrolledInMSA { get; set; }

        public Programming()
        {
            StudentNZQACourses.Add(new NZQACourses("Programming", "NZQA101", true, "2018"));
        }

    }

}


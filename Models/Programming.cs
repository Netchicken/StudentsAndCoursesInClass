using StudentsAndCoursesInClass.Operations;

namespace StudentsAndCoursesInClass.Models
{
    public class Programming : Student
    {

        public bool HasLaptop { get; set; }
        public bool IsEnrolledInMSA { get; set; }

        public Programming()
        {
            ID = 1;
            FirstName = "Conan";
            LastName = "the Barbarian";
            Course.Name = "DSD";
            Course.Tutor = "Gary";
            AddStudentHardware("Laptop");
            AddStudentHardware("Mouse");

            StudentNZQACourses.Add(new NZQACourses("Programming", "NZQA101", true, "2020"));
        }


        public override void AddStudentHardware(string hardware)
        {
            StudentHardware.Add(hardware + "  Cool stuff programmers use ");
        }




    }

}


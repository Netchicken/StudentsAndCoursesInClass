using StudentsAndCoursesInClass.Operations;

namespace StudentsAndCoursesInClass.Models
{
    public class Web : Student
    {
        public bool HasPhotoShop { get; set; }



        public Web()
        {
            ID = 1;
            FirstName = "Howard";
            LastName = "the barbarian";
            Course.Name = "DSD";
            Course.Tutor = "Jeffery";


            AddStudentHardware("Big old desktop running a 486");
            AddStudentHardware("Wireless mouse with glowing lights");

            MainTransportType.Add("Electric skateboard");
            StudentNZQACourses.Add(new NZQACourses("Web", "NZQA101", true, "2018"));

        }


        

        public override void AddStudentHardware(string hardware)
        {
            StudentHardware.Add(hardware + "  Not so cool stuff that web designers use, probably in JS ");
        }




    }
}

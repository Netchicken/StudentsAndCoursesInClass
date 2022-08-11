using StudentsAndCoursesInClass.Interfaces;
using StudentsAndCoursesInClass.Operations;

namespace StudentsAndCoursesInClass.Models
{
    public class Student : IStudent
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public Course Course { get; set; }

        public ContactDetails ContactDetails { get; set; }

        public List<string> StudentHardware { get; set; }

        public List<string> MainTransportType { get; set; }

        public List<NZQACourses> StudentNZQACourses { get; set; }

        //public int? StudentSelected { get; set; }

        public Student()
        {
            Course = new Course();
            ContactDetails = new ContactDetails();
            StudentHardware = new List<string>();
            MainTransportType = new List<string>();

            MainTransportType.Add("Car");
            MainTransportType.Add("Bus");
            MainTransportType.Add("Cycle");
            MainTransportType.Add("Walk");

            StudentNZQACourses = new List<NZQACourses>();

        }

        public virtual void AddStudentHardware(string hardware)
        {
            StudentHardware.Add(hardware);
        }



    }
}

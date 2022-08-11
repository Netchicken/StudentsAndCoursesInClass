using StudentsAndCoursesInClass.Models;
using StudentsAndCoursesInClass.Operations;

namespace StudentsAndCoursesInClass.Interfaces
{
    public interface IStudent
    {
        ContactDetails ContactDetails { get; set; }
        Course Course { get; set; }
        DateTime DOB { get; set; }
        string FirstName { get; set; }
        int ID { get; set; }
        string LastName { get; set; }
        List<string> MainTransportType { get; set; }
        List<string> StudentHardware { get; set; }
        List<NZQACourses> StudentNZQACourses { get; set; }
        //int? StudentSelected { get; set; }
    }
}
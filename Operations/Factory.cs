using StudentsAndCoursesInClass.Models;

namespace StudentsAndCoursesInClass.Operations
{
    public static class Factory
    {
        public static Student GetAStudent(int? id)
        {
            switch (id)
            {

                case 1:
                    return new Programming();

                case 2:
                    return new Web();



                default:
                    return new Web();
            }




        }



    }
}

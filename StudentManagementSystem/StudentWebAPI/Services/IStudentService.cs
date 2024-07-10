using StudentWebAPI.Entities;

namespace StudentWebAPI.Services
{
    public interface IStudentService
    {
        List<Student> GetAllStudent();

        Student GetStudent(int id); 

        void AddStudent(Student student);

        void UpdateStudent(int id,string status);

        void DeleteStudent(int id);

        List<Student>  SearchByStatus(string status);

        List<Student> SortByStatus();



    }
}

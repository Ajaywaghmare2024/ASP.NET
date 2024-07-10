using StudentWebApp.Models;

namespace StudentWebApp.Services
{
    public interface IStudentService
    {
        void AddStudent(Student student);

        List<Student> GetAllStudents();

        List<Student> SearchStudentByStatus(string status);

        void UpdateStudent(Student student);

        void DeleteStudent(int id);

       List<Student> SortByStatus();


    }
}

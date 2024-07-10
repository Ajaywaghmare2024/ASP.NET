using Microsoft.AspNetCore.Http.HttpResults;
using StudentWebAPI.Entities;
using StudentWebAPI.Repositories;

namespace StudentWebAPI.Services
{
    public class StudentService : IStudentService
    {

        private readonly DbStudnetContext _context =new DbStudnetContext();
        public void AddStudent(Student student)
        {
           using (var context=new DbStudnetContext())
            {
                context.students.Add(student);
                context.SaveChanges();
            }
        }

        public void DeleteStudent(int id)
        {
            using (var context = new DbStudnetContext())
            {
                var student = context.students.Find(id);
                if (student != null)
                {
                    context.students.Remove(student);
                    context.SaveChanges();
                }
            }
        }

        public List<Student> GetAllStudent()
        {
            return _context.students.ToList();  

        }

        public Student GetStudent(int id)
        {
            using (var context=new DbStudnetContext())
            {
                var student = context.students.Find(id);
                return student;
            }
        }

        public List<Student> SearchByStatus(string status)
        {
            using (var context = new DbStudnetContext())
            {
                var search = context.students.Where(s => s.Status == status).ToList();

                return search;


            }
        }

        public List<Student> SortByStatus()
        {
            using (var context = new DbStudnetContext())
            {
                var stu=context.students.OrderBy(s => s.Status== "Active" ? 0:1).ToList();
                return stu;
            }
        }

        public void UpdateStudent(int id,string status)
        {
            using (var context = new DbStudnetContext())
            {
                var stud = context.students.Find(id);
                if (stud != null)
                {
                    stud.Student_Id = id;

                    stud.Status =status;


                    context.students.Update(stud);
                    context.SaveChanges();  
                }
            }
       }
    }
}

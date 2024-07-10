using Org.BouncyCastle.Asn1.X509;
using StudentWebApp.Models;
using StudentWebApp.Repositories;

namespace StudentWebApp.Services
{
    public class StudentService : IStudentService

    {
        private readonly DbStudentContext _studentContext = new DbStudentContext();
        public void AddStudent(Student student)
        {
            using (var context = new DbStudentContext())
            {
                context.students.Add(student);
                context.SaveChanges();
            }
        }


        public void DeleteStudent(int id)
        {
            using (var context = new DbStudentContext())
            {
                var student = context.students.Find(id);
                if (student != null)
                {

                    context.students.Remove(student);
                    context.SaveChanges();
                }
            }
        }

        public List<Student> GetAllStudents()
        {
            return _studentContext.students.ToList();


        }

        public List<Student> SearchStudentByStatus(string status)
        {
            using (var context = new DbStudentContext())
            {
                var students = context.students.Where(s => s.Status == status).ToList();
                return students.ToList();
            }
        }

        public List<Student> SortByStatus()
        {
           using(var context=new DbStudentContext())
            {
                var SortStudent =  context.students.OrderBy(s => s.Status =="Active"?0:1).ToList();
                return SortStudent;
                        
                    
            }
        }

        public void UpdateStudent(Student student)
        {
            using (var context = new DbStudentContext())
            {
                var stud = context.students.Find(student.Student_Id);


                stud.Student_Name = student.Student_Name;
                stud.Mobile_Number = student.Mobile_Number;
                context.students.Update(stud);
                context.SaveChanges();

            }
        }
    }
}

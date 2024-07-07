using EmployeeApp.Entities;
using EmployeeApp.Repositories;

namespace EmployeeApp.Services
{
    public class EmployeeService : IEmployeeService
    {

        private DbEmployeeContext _employeeContext=new DbEmployeeContext();
        public void AddEmployee(Employee employee)
        {
            using (var context = new DbEmployeeContext())
            {
                context.employees.Add(employee);
                context.SaveChanges();
            }
        }

        public void DeleteEmployee(int id)
        {
            using (var context = new DbEmployeeContext())
            {
                var employee = context.employees.Find(id);
                if (employee != null)
                {
                    context.employees.Remove(employee);
                    context.SaveChanges();
                }
            }
        }

        public List<Employee> GetAllEmployees()
        {
            return _employeeContext.employees.ToList();
        }

        public Employee GetById(int id)
        {
            using (var context = new DbEmployeeContext())
            {
                var employee= context.employees.Find(id);
                return employee;

                
                
               
            }
            


        }

        public void UpdateEmployee(int id,int age)
        {

            using (var context = new DbEmployeeContext())
            {
                var emp = _employeeContext.employees.Find(id);
                if (emp != null)
                {
                    emp.Id = id;
                    emp.Age = age;

                    context.Update(emp);

                    context.SaveChanges();


                }
            }

        }

       
    }
}

using EmployeeApp.Entities;

namespace EmployeeApp.Services
{
    public interface IEmployeeService
    {
        List<Employee> GetAllEmployees();

        Employee GetById(int id);

        void AddEmployee(Employee employee);

        void UpdateEmployee(int id,int age);

        void DeleteEmployee(int id);


    }
}

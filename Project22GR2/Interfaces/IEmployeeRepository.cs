using Project22GR2.Models;

namespace Project22GR2.Interfaces
{
    public interface IEmployeeRepository
    {
        List<Employee> GetAllEmployees();
        Employee GetEmployee(int id);

        void AddEmployee(Employee employees);

        void UpdateEmployee(Employee employees);

        void DeleteEmployee(int id);

        List<Employee> FilterEmployee(string filter);

    }
}

using Project22GR2.Helpers;
using Project22GR2.Interfaces;
using Project22GR2.Models;

namespace Project22GR2.Services
{
    public class JsonEmployeeRepository : IEmployeeRepository
    {
        string jsonFileName = @"Data\JsonEmployees.json";
        public void AddEmployee(Employee employees)
        {
            List<Employee> employee = GetAllEmployees();
            employee.Add(employees);
            JsonFileWriter.WritetoJsonEmployees(employee, jsonFileName);
        }

        public void DeleteEmployee(int id)
        {
            Employee memberToDelete = GetEmployee(id);
            List<Employee> employee = GetAllEmployees();
            employee.Remove(memberToDelete);
            JsonFileWriter.WritetoJsonEmployees(employee, jsonFileName);
        }

        public List<Employee> FilterEmployee(string filter)
        {
            List<Employee> filteredList = new List<Employee>();
            foreach (var item in GetAllEmployees())
            {
                if (item.Name.Contains(filter) || item.Address.Contains(filter))
                {
                    filteredList.Add(item);
                }
            }
            return filteredList;
        }

        public List<Employee> GetAllEmployees()
        {
            return JsonFileReader.ReadJsonEmployees(jsonFileName);
        }

        public Employee GetEmployee(int id)
        {
            List<Employee> employees = GetAllEmployees();
            foreach (Employee e in employees)
            {
                if (e.Id == id)
                    return e;
            }
            return new Employee();
        }

        public void UpdateEmployee(Employee employees)
        {
            if (employees!= null)
            {
                List<Employee> employee = GetAllEmployees();
                foreach (Employee e in employee)
                {
                    if (e.Id == employees.Id)
                    {
                        e.Id = employees.Id;
                        e.Name = employees.Name;
                        e.Address = employees.Address;
                        e.Email = employees.Email;
                    }
                }
                JsonFileWriter.WritetoJsonEmployees(employee, jsonFileName);
            }
        }
    }
}

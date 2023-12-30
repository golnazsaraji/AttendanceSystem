using System;
using AttendanceSystem.Domain.Entities;
using AttendanceSystem.DataAccess.Interfaces;
using AttendanceSystem.Application.Interfaces;

namespace AttendanceSystem.Application.Services
{
	public class EmployeeService: IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeService(IEmployeeRepository employeeRepository)
		{
            _employeeRepository = employeeRepository;
		}


        public void Join(Employee employee) {
            _employeeRepository.Join(employee);
        }

        public Employee GetEmployee(int employeeId) {
           return _employeeRepository.GetEmployee(employeeId);
        }

        public IEnumerable<Employee> GetEmployees() {
            return _employeeRepository.GetEmployees();
        }

        public void Leave(int employeeId) {
            _employeeRepository.Leave(employeeId);
        }

        public void Delete(int employeeId) {
            _employeeRepository.Delete(employeeId);
        }
    }
}

